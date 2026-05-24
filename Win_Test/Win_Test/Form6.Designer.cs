namespace Win_Test
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penWidthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.penButton = new System.Windows.Forms.ToolStripButton();
            this.eraserButton = new System.Windows.Forms.ToolStripButton();
            this.lineButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sizeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.windowMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            new System.Windows.Forms.ToolStripSeparator(),
            this.openMenuItem,
            this.closeMenuItem,
            this.closeAllMenuItem,
            new System.Windows.Forms.ToolStripSeparator(),
            this.saveMenuItem,
            this.saveAsMenuItem,
            new System.Windows.Forms.ToolStripSeparator(),
            this.pageSetupMenuItem,
            this.printMenuItem,
            this.printPreviewMenuItem,
            new System.Windows.Forms.ToolStripSeparator(),
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileMenuItem.Text = "파일(&F)";
            // 
            // file drop-down
            // 
            this.newMenuItem.Text = "새로 만들기(&N)";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            this.openMenuItem.Text = "열기(&O)";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            this.closeMenuItem.Text = "닫기(&C)";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            this.closeAllMenuItem.Text = "모두 닫기";
            this.closeAllMenuItem.Click += new System.EventHandler(this.closeAllMenuItem_Click);
            this.saveMenuItem.Text = "저장(&S)";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            this.saveAsMenuItem.Text = "다른 이름으로 저장(&A)";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            this.pageSetupMenuItem.Text = "페이지 설정(&U)";
            this.pageSetupMenuItem.Click += new System.EventHandler(this.pageSetupMenuItem_Click);
            this.printMenuItem.Text = "출력(&P)";
            this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
            this.printPreviewMenuItem.Text = "미리보기(&R)";
            this.printPreviewMenuItem.Click += new System.EventHandler(this.printPreviewMenuItem_Click);
            this.exitMenuItem.Text = "끝내기(&X)";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            new System.Windows.Forms.ToolStripSeparator(),
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editMenuItem.Text = "편집(&E)";
            this.undoMenuItem.Text = "지우기 취소(&Z)";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            this.cutMenuItem.Text = "잘라내기(&X)";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            this.copyMenuItem.Text = "복사(&C)";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            this.pasteMenuItem.Text = "붙여넣기(&V)";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorMenuItem,
            this.backColorMenuItem,
            this.penWidthMenuItem,
            this.clearMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(58, 20);
            this.formatMenuItem.Text = "서식(&S)";
            this.penColorMenuItem.Text = "펜 색(&F)";
            this.penColorMenuItem.Click += new System.EventHandler(this.penColorMenuItem_Click);
            this.backColorMenuItem.Text = "배경색(&B)";
            this.backColorMenuItem.Click += new System.EventHandler(this.backColorMenuItem_Click);
            this.penWidthMenuItem.Text = "선 굵기(&W)";
            this.penWidthMenuItem.Click += new System.EventHandler(this.penWidthMenuItem_Click);
            this.clearMenuItem.Text = "모두 지우기";
            this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeMenuItem,
            this.tileHorizontalMenuItem,
            this.tileVerticalMenuItem,
            this.arrangeIconsMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(50, 20);
            this.windowMenuItem.Text = "창(&W)";
            this.cascadeMenuItem.Text = "계단식 정렬";
            this.cascadeMenuItem.Click += new System.EventHandler(this.cascadeMenuItem_Click);
            this.tileHorizontalMenuItem.Text = "바둑판식 정렬";
            this.tileHorizontalMenuItem.Click += new System.EventHandler(this.tileHorizontalMenuItem_Click);
            this.tileVerticalMenuItem.Text = "아이콘식 정렬";
            this.tileVerticalMenuItem.Click += new System.EventHandler(this.tileVerticalMenuItem_Click);
            this.arrangeIconsMenuItem.Text = "아이콘 정렬";
            this.arrangeIconsMenuItem.Click += new System.EventHandler(this.arrangeIconsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(72, 20);
            this.helpMenuItem.Text = "도움말(&H)";
            this.aboutMenuItem.Text = "정보(&A)";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.printButton,
            new System.Windows.Forms.ToolStripSeparator(),
            this.undoButton,
            this.copyButton,
            this.pasteButton,
            new System.Windows.Forms.ToolStripSeparator(),
            this.penButton,
            this.eraserButton,
            this.lineButton,
            this.rectangleButton,
            this.ellipseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(920, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolbar buttons
            // 
            this.newButton.Text = "새로";
            this.newButton.Click += new System.EventHandler(this.newMenuItem_Click);
            this.openButton.Text = "열기";
            this.openButton.Click += new System.EventHandler(this.openMenuItem_Click);
            this.saveButton.Text = "저장";
            this.saveButton.Click += new System.EventHandler(this.saveMenuItem_Click);
            this.printButton.Text = "출력";
            this.printButton.Click += new System.EventHandler(this.printMenuItem_Click);
            this.undoButton.Text = "취소";
            this.undoButton.Click += new System.EventHandler(this.undoMenuItem_Click);
            this.copyButton.Text = "복사";
            this.copyButton.Click += new System.EventHandler(this.copyMenuItem_Click);
            this.pasteButton.Text = "붙여넣기";
            this.pasteButton.Click += new System.EventHandler(this.pasteMenuItem_Click);
            this.penButton.Text = "펜";
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            this.eraserButton.Text = "지우개";
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            this.lineButton.Text = "선";
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            this.rectangleButton.Text = "사각형";
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            this.ellipseButton.Text = "타원";
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStatusLabel,
            this.sizeStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusLabel.Text = "준비";
            this.toolStatusLabel.Spring = true;
            this.toolStatusLabel.Text = "도구: 펜";
            this.sizeStatusLabel.Text = "800 x 500";
            // 
            // dialogs
            // 
            this.openFileDialog1.Filter = "이미지 파일|*.png;*.jpg;*.jpeg;*.bmp;*.gif|모든 파일|*.*";
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG 이미지|*.png|JPEG 이미지|*.jpg|Bitmap 이미지|*.bmp";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제목 없음 - 그림판";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MdiChildActivate += new System.EventHandler(this.Form6_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penWidthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton printButton;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripButton penButton;
        private System.Windows.Forms.ToolStripButton eraserButton;
        private System.Windows.Forms.ToolStripButton lineButton;
        private System.Windows.Forms.ToolStripButton rectangleButton;
        private System.Windows.Forms.ToolStripButton ellipseButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel sizeStatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
