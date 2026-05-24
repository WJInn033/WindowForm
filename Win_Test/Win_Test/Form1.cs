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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Length > 0 && txt_Pass.Text.Length > 0)
            {
                MessageBox.Show(txt_ID.Text + "님 반갑습니다.");
            }
            else if (txt_ID.Text.Length == 0)
            {
                MessageBox.Show("아이디를 입력해주세요.","확인",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txt_Pass.Text.Length == 0)
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //현재객체만 죽임
            //Application.Exit(); //아예 죽임 
        }

        private void Lbl_ID_Click(object sender, EventArgs e)
        {
        }

        private void Log_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("종료할까요?", "확인", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
