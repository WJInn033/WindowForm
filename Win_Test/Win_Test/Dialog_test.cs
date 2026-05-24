using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test
{
    public partial class Dialog_test : Form
    {
        public Dialog_test()
        {
            InitializeComponent();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            { Txt_memo.Font = fontDialog1.Font; }
        }

        private void Btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { Txt_memo.ForeColor = colorDialog1.Color; }
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트문서(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = @"C:\Test111";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                String File_name = openFileDialog1.FileName;
                StreamReader str = new StreamReader(File_name,Encoding.UTF8);
                Txt_memo.Text = str.ReadToEnd();
                str.Close();
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트문서(*.txt)|*.txt|모든파일(*.*)|*.*";
            saveFileDialog1.OverwritePrompt = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String File_name = saveFileDialog1.FileName;
                StreamWriter stw = new StreamWriter(File_name, false, Encoding.UTF8);
                stw.Write(Txt_memo.Text);
                stw.Flush();
                stw.Close();
            }
        }
    }
}
