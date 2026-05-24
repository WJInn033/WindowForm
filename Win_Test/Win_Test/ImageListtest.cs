using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test
{
    public partial class ImageListtest : Form
    {
        public ImageListtest()
        {
            InitializeComponent();
        }

        private void ImageListtest_Load(object sender, EventArgs e)
        {
            lbl_message.Text = "준비되었습니다.";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            txt_memo.Undo();
            lbl_message.Text = "실행을 취소하였습니다.";
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if(txt_memo.SelectionLength > 0 )
            {
                txt_memo.Copy();
                lbl_message.Text = "복사를 실행하였습니다.";
            }
            else
            {
                MessageBox.Show("영역이 선택되지 않았습니다.");
            }
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            if (txt_memo.SelectionLength > 0)
            {
                txt_memo.Copy();
                lbl_message.Text = "자르기를 실행하였습니다.";
            }
            else
            {
                MessageBox.Show("영역이 선택되지 않았습니다.");
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            txt_memo.Paste();
        }
    }
}
