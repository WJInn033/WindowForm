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
    public partial class Tab_Test : Form
    {
        public Tab_Test()
        {
            InitializeComponent();
        }

        private void Tab_Test_Load(object sender, EventArgs e)
        {

            for (int i = 7; i<128; i++)
            {
                cmb_size.Items.Add(i);
            }

            cmb_size.Text = cmb_size.Items[5].ToString();

            foreach (FontFamily fontname in FontFamily.Families)
            {
                cmb_font.Items.Add(fontname.Name);
            }

            cmb_font.Text = cmb_font.Items[6].ToString();

            cmb_style.Items.Add(FontStyle.Bold);
            cmb_style.Items.Add(FontStyle.Italic);
            cmb_style.Items.Add(FontStyle.Underline);
            cmb_style.Items.Add(FontStyle.Strikeout);


            cmb_color.Items.Add(Color.Red.Name);
            cmb_color.Items.Add(Color.Blue.Name);
            cmb_color.Items.Add(Color.Purple.Name);
            cmb_color.Items.Add(Color.Yellow.Name);
            cmb_color.Items.Add(Color.DarkBlue.Name);

            cmb_color.Text = cmb_color.Items[0].ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string Font_name = cmb_font.SelectedItem.ToString();
            int Font_size = Int32.Parse(cmb_size.SelectedItem.ToString());
            FontStyle Font_Style = (FontStyle) cmb_style.SelectedItem;

            lbl_text.Font = new Font(Font_name, Font_size, Font_Style);
            lbl_text.ForeColor = Color.FromName(cmb_color.Text);
        }

        private void btn_radio_ok_Click(object sender, EventArgs e)
        {
            string Order = "";
            foreach(RadioButton rb in gb_food.Controls)
            {
                if(rb.Checked == true)
                {
                    Order = rb.Text;
                }
            }

            foreach(RadioButton rb in gb_app.Controls)
            {
                if(rb.Checked == true)
                {
                    Order += ", " + rb.Text;
                }
            }

            if (MessageBox.Show("주문하신 메뉴와 음료수는 " + Order + "입니다. 주문하시겠습니까?",
                "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("주문이 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("주문이 취소되었습니다.");
            }
        }

        private void btn_chk_ok_Click(object sender, EventArgs e)
        {
            string Order = "";

            foreach(CheckBox cb in gb_part.Controls)
            {
                if(cb.Checked == true)
                {
                    Order = ", " + cb.Text;
                }

                Order = Order.TrimEnd(',', ' ');

                if (MessageBox.Show("주문하신 부품은 " + Order + "입니다. 주문하시겠습니까?",
                    "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("주문이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("주문이 취소되었습니다.");
                }
            }
        }
    }
}
