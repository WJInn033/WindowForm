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
    public partial class Vaild_Test : Form
    {
        public Vaild_Test()
        {
            InitializeComponent();
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            if(txt_name.Text.Length == 0)
            {
                lbl_message.Text = "이름을 입력하세요.";
                e.Cancel = true;
            }
        }

        private void lbl_message_Validated(object sender, EventArgs e)
        {
            lbl_message.Text = "";
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (txt_email.Text.Length == 0)
            {
                lbl_message.Text = "이메일을 입력하세요.";
                e.Cancel = true;
            }
            else if (txt_email.Text.IndexOf(".") == -1 || txt_email.Text.IndexOf("@") == -1)
            {
                lbl_message.Text = "정확한 이메일의 형식을 입력해주세요.";
                e.Cancel = true;
            }
        }
        private void txt_home_Validating(object sender, CancelEventArgs e)
        {
            //반환값이 두개가 생긴다.
            bool result = Int32.TryParse(txt_home.Text, out int value);
            if (txt_home.Text.Length == 0)
            {
                lbl_message.Text = "집전화 번호를 입력하세요.";
                e.Cancel = true;
            }
            else if(!result)
            {
                lbl_message.Text = "집전화 번호를 정확히 입력하세요.";
                e.Cancel = true;
            }
        }

        private void txt_cell_Validating(object sender, CancelEventArgs e)
        {
            bool result = Int32.TryParse(txt_cell.Text, out int value);
            if (txt_cell.Text.Length == 0)
            {
                lbl_message.Text = "휴대폰 번호를 입력하세요.";
                e.Cancel = true;
            }
            else if (!result)
            {
                lbl_message.Text = "휴대폰 번호를 정확히 입력하세요.";
                e.Cancel = true;
            }
        }
        }
    }

