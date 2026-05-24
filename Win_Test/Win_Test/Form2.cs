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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_modal_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Text = "모달 대화 상자";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("입력하신 이름은" + dlg.txt_name.Text + "입니다");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_modeless_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Text = "모달 대화 상자";

            dlg.Show();
        }
    }
}
