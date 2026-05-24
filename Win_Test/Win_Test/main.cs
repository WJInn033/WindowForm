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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_child_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.TopLevel = false;
            child.Parent = this;
            child.BringToFront();
            child.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_own_Click(object sender, EventArgs e)
        {
            Form4 own = new Form4();
            this.AddOwnedForm(own);
            own.Show();
        }
    }
}
