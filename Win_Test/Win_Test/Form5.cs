using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Test
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Thread th = null;
        bool th_go = false;

        private void Form5_Load(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(Th_Work));
            th.IsBackground = true;
            th.Start();
        }

        private void Th_Work()
        {
            while(!th_go)
            {
                label1.Text = DateTime.Now.ToLongTimeString();
                Thread.Sleep(1000);
            }
        }

    }
}
