using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Win_Test
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // 새로 만들기
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("새로 시작하시겠습니까? 기존 작업이 지워질 수 있습니다.", "새로 만들기",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                this.Text = "제목 없음 - 내 프로그램";
            }
        }

        // 열기
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = System.IO.File.ReadAllText(openFileDialog1.FileName, System.Text.Encoding.Default);
                    textBox1.Text = content;

                    this.Text = openFileDialog1.FileName + " - 내 프로그램";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일을 열 수 없습니다: " + ex.Message);
                }
            }
        }

        // 닫기
        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 모두 닫기
        private void closeAllMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("열려 있는 모든 작업을 마치고 종료 하시겠습니까?", "모두 닫기",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 저장
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, System.Text.Encoding.Default);
                    MessageBox.Show("성공적으로 저장되었습니다.");
                    this.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("저장 중 오류가 발생했습니다: " + ex.Message);
                }
            }
        }

        // 다른 이름으로 저장
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "다른 이름으로 저장";
            saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, System.Text.Encoding.Default);
                    this.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("저장 실패: " + ex.Message);
                }
            }
        }

        // 페이지 설정
        private void pageSetupMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        // 출력
        private void 출력PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        // 미리보기
        private void printPreviewMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // 인쇄 페이지 그리기
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        // 끝내기
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 지우기 취소
        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
            }
        }

        // 잘라내기
        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        // 복사
        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        // 붙여넣기
        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        // 글꼴
        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        // 배경색
        private void backColorMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = colorDialog1.Color;
        }

        // 계단식 정렬
        private void cascadeMenuItem_Click(object sender, EventArgs e)
        {
        }

        // 바둑판식 정렬
        private void 바둑판식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // 아이콘식 정렬
        private void 아이콘식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 새로 만들기
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 열기
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 저장
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 출력
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 잘라내기
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 복사
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 붙여넣기
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 지우기 취소
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 글꼴
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
        }

        // 툴바: 배경색
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
        }
    }
}