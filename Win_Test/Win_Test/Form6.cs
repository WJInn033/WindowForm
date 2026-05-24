using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Win_Test
{
    public partial class Form6 : Form
    {
        private int documentNumber = 1;

        public Form6()
        {
            InitializeComponent();
        }

        private PaintDocument ActiveDocument
        {
            get { return ActiveMdiChild as PaintDocument; }
        }

        private PaintCanvas ActiveCanvas
        {
            get { return ActiveDocument == null ? null : ActiveDocument.Canvas; }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        private void Form6_MdiChildActivate(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using (Image source = Image.FromFile(openFileDialog1.FileName))
                {
                    PaintDocument doc = CreateNewDocument(Path.GetFileName(openFileDialog1.FileName), false);
                    doc.FileName = openFileDialog1.FileName;
                    doc.Canvas.LoadImage(source);
                    doc.Text = Path.GetFileName(openFileDialog1.FileName);
                }
                statusLabel.Text = "이미지를 열었습니다.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "파일을 열 수 없습니다.\r\n" + ex.Message, "열기 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveDocument != null)
            {
                ActiveDocument.Close();
            }
        }

        private void closeAllMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument(false);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument(true);
        }

        private void pageSetupMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog(this);
        }

        private void printMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            Bitmap image = ActiveCanvas.CreateSnapshot();
            Rectangle target = FitRectangle(image.Size, e.MarginBounds);
            e.Graphics.DrawImage(image, target);
            image.Dispose();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas != null)
            {
                ActiveCanvas.Undo();
            }
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            copyMenuItem_Click(sender, e);
            ActiveCanvas.ClearCanvas();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas != null)
            {
                Clipboard.SetImage(ActiveCanvas.CreateSnapshot());
                statusLabel.Text = "그림을 복사했습니다.";
            }
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas != null && Clipboard.ContainsImage())
            {
                ActiveCanvas.PasteImage(Clipboard.GetImage());
                statusLabel.Text = "그림을 붙여넣었습니다.";
            }
        }

        private void penColorMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            colorDialog1.Color = ActiveCanvas.PenColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveCanvas.PenColor = colorDialog1.Color;
                statusLabel.Text = "펜 색을 변경했습니다.";
            }
        }

        private void backColorMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            colorDialog1.Color = ActiveCanvas.CanvasColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                ActiveCanvas.SetCanvasColor(colorDialog1.Color);
                statusLabel.Text = "배경색을 변경했습니다.";
            }
        }

        private void penWidthMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            ActiveCanvas.PenWidth = ActiveCanvas.PenWidth >= 12 ? 2 : ActiveCanvas.PenWidth + 2;
            statusLabel.Text = "선 굵기: " + ActiveCanvas.PenWidth;
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveCanvas != null)
            {
                ActiveCanvas.ClearCanvas();
            }
        }

        private void cascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "클래식 그림판 메뉴 예제입니다.", "도움말", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            SetTool(DrawingTool.Pen);
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            SetTool(DrawingTool.Eraser);
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            SetTool(DrawingTool.Line);
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            SetTool(DrawingTool.Rectangle);
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            SetTool(DrawingTool.Ellipse);
        }

        private PaintDocument CreateNewDocument(string title = null, bool activate = true)
        {
            PaintDocument doc = new PaintDocument();
            doc.MdiParent = this;
            doc.Text = title ?? "문서" + documentNumber++;
            doc.Canvas.CanvasChanged += delegate { UpdateStatus(); };
            doc.Show();
            if (activate)
            {
                doc.Activate();
            }
            return doc;
        }

        private void SaveDocument(bool saveAs)
        {
            PaintDocument doc = ActiveDocument;
            if (doc == null)
            {
                return;
            }

            if (saveAs || string.IsNullOrEmpty(doc.FileName))
            {
                saveFileDialog1.FileName = doc.FileName ?? doc.Text + ".png";
                if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                doc.FileName = saveFileDialog1.FileName;
            }

            try
            {
                ImageFormat format = GetImageFormat(doc.FileName);
                using (Bitmap image = doc.Canvas.CreateSnapshot())
                {
                    image.Save(doc.FileName, format);
                }
                doc.Text = Path.GetFileName(doc.FileName);
                statusLabel.Text = "저장했습니다.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "저장할 수 없습니다.\r\n" + ex.Message, "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTool(DrawingTool tool)
        {
            if (ActiveCanvas == null)
            {
                return;
            }

            ActiveCanvas.Tool = tool;
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            PaintCanvas canvas = ActiveCanvas;
            if (canvas == null)
            {
                statusLabel.Text = "문서 없음";
                toolStatusLabel.Text = string.Empty;
                sizeStatusLabel.Text = string.Empty;
                return;
            }

            statusLabel.Text = ActiveDocument.Text;
            toolStatusLabel.Text = "도구: " + canvas.ToolText + " / 선 굵기: " + canvas.PenWidth;
            sizeStatusLabel.Text = canvas.ImageSize.Width + " x " + canvas.ImageSize.Height;
        }

        private static ImageFormat GetImageFormat(string fileName)
        {
            string extension = Path.GetExtension(fileName).ToLowerInvariant();
            if (extension == ".jpg" || extension == ".jpeg")
            {
                return ImageFormat.Jpeg;
            }
            if (extension == ".bmp")
            {
                return ImageFormat.Bmp;
            }
            return ImageFormat.Png;
        }

        private static Rectangle FitRectangle(Size imageSize, Rectangle bounds)
        {
            float scale = Math.Min((float)bounds.Width / imageSize.Width, (float)bounds.Height / imageSize.Height);
            int width = (int)(imageSize.Width * scale);
            int height = (int)(imageSize.Height * scale);
            int x = bounds.Left + (bounds.Width - width) / 2;
            int y = bounds.Top + (bounds.Height - height) / 2;
            return new Rectangle(x, y, width, height);
        }
    }

    internal enum DrawingTool
    {
        Pen,
        Eraser,
        Line,
        Rectangle,
        Ellipse
    }

    internal sealed class PaintDocument : Form
    {
        public PaintDocument()
        {
            Canvas = new PaintCanvas();
            Canvas.Dock = DockStyle.Fill;
            AutoScroll = true;
            ClientSize = new Size(800, 500);
            Controls.Add(Canvas);
        }

        public string FileName { get; set; }

        public PaintCanvas Canvas { get; private set; }
    }

    internal sealed class PaintCanvas : Control
    {
        private readonly Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Bitmap image;
        private Point startPoint;
        private Point lastPoint;
        private bool drawing;

        public PaintCanvas()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            PenColor = Color.Black;
            CanvasColor = Color.White;
            PenWidth = 2;
            Tool = DrawingTool.Pen;
            image = CreateBlankBitmap(new Size(800, 500), CanvasColor);
            Size = image.Size;
            Cursor = Cursors.Cross;
        }

        public event EventHandler CanvasChanged;

        public Color PenColor { get; set; }

        public Color CanvasColor { get; private set; }

        public int PenWidth { get; set; }

        public DrawingTool Tool { get; set; }

        public Size ImageSize
        {
            get { return image.Size; }
        }

        public string ToolText
        {
            get
            {
                switch (Tool)
                {
                    case DrawingTool.Eraser:
                        return "지우개";
                    case DrawingTool.Line:
                        return "선";
                    case DrawingTool.Rectangle:
                        return "사각형";
                    case DrawingTool.Ellipse:
                        return "타원";
                    default:
                        return "펜";
                }
            }
        }

        public void LoadImage(Image source)
        {
            PushUndo();
            Bitmap next = new Bitmap(source.Width, source.Height);
            using (Graphics graphics = Graphics.FromImage(next))
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(source, 0, 0, source.Width, source.Height);
            }
            ReplaceImage(next);
        }

        public Bitmap CreateSnapshot()
        {
            return new Bitmap(image);
        }

        public void PasteImage(Image source)
        {
            if (source == null)
            {
                return;
            }

            PushUndo();
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.DrawImage(source, 10, 10, source.Width, source.Height);
            }
            Invalidate();
            OnCanvasChanged();
        }

        public void SetCanvasColor(Color color)
        {
            PushUndo();
            CanvasColor = color;
            using (Graphics graphics = Graphics.FromImage(image))
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    graphics.FillRectangle(brush, ClientRectangle);
                }
            }
            Invalidate();
            OnCanvasChanged();
        }

        public void ClearCanvas()
        {
            PushUndo();
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(CanvasColor);
            }
            Invalidate();
            OnCanvasChanged();
        }

        public void Undo()
        {
            if (undoStack.Count == 0)
            {
                return;
            }

            ReplaceImage(undoStack.Pop());
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            PushUndo();
            drawing = true;
            startPoint = e.Location;
            lastPoint = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!drawing)
            {
                return;
            }

            if (Tool == DrawingTool.Pen || Tool == DrawingTool.Eraser)
            {
                using (Graphics graphics = Graphics.FromImage(image))
                using (Pen pen = CreatePen())
                {
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    graphics.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                Invalidate();
            }
            else
            {
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (!drawing)
            {
                return;
            }

            drawing = false;
            if (Tool == DrawingTool.Line || Tool == DrawingTool.Rectangle || Tool == DrawingTool.Ellipse)
            {
                using (Graphics graphics = Graphics.FromImage(image))
                using (Pen pen = CreatePen())
                {
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    DrawShape(graphics, pen, startPoint, e.Location);
                }
            }
            Invalidate();
            OnCanvasChanged();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImageUnscaled(image, Point.Empty);

            if (drawing && Tool != DrawingTool.Pen && Tool != DrawingTool.Eraser)
            {
                using (Pen pen = CreatePen())
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    DrawShape(e.Graphics, pen, startPoint, PointToClient(MousePosition));
                }
            }
        }

        private Pen CreatePen()
        {
            Color color = Tool == DrawingTool.Eraser ? CanvasColor : PenColor;
            Pen pen = new Pen(color, PenWidth);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            return pen;
        }

        private void DrawShape(Graphics graphics, Pen pen, Point start, Point end)
        {
            Rectangle rectangle = GetRectangle(start, end);
            if (Tool == DrawingTool.Line)
            {
                graphics.DrawLine(pen, start, end);
            }
            else if (Tool == DrawingTool.Rectangle)
            {
                graphics.DrawRectangle(pen, rectangle);
            }
            else if (Tool == DrawingTool.Ellipse)
            {
                graphics.DrawEllipse(pen, rectangle);
            }
        }

        private static Rectangle GetRectangle(Point first, Point second)
        {
            return new Rectangle(
                Math.Min(first.X, second.X),
                Math.Min(first.Y, second.Y),
                Math.Abs(first.X - second.X),
                Math.Abs(first.Y - second.Y));
        }

        private void PushUndo()
        {
            undoStack.Push(new Bitmap(image));
            while (undoStack.Count > 20)
            {
                Bitmap old = undoStack.ToArray()[undoStack.Count - 1];
                old.Dispose();
                break;
            }
        }

        private void ReplaceImage(Bitmap next)
        {
            if (image != null)
            {
                image.Dispose();
            }
            image = next;
            Size = image.Size;
            Invalidate();
            OnCanvasChanged();
        }

        private void OnCanvasChanged()
        {
            if (CanvasChanged != null)
            {
                CanvasChanged(this, EventArgs.Empty);
            }
        }

        private static Bitmap CreateBlankBitmap(Size size, Color color)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(color);
            }
            return bitmap;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && image != null)
            {
                image.Dispose();
                while (undoStack.Count > 0)
                {
                    undoStack.Pop().Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
