using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Win_Test
{
    public partial class LIst : Form
    {
        public LIst()
        {
            InitializeComponent();
        }

        private void LIst_Load(object sender, EventArgs e)
        {
            List_Source.Items.AddRange(new string[] {"키보드", "마우스", "메인보드", "모니터", "스피커", "하드디스크"
            ,"메인메모리", "USB메모리", "프린터" });
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Move_Click(object sender, EventArgs e)
        {
            if (List_Source.SelectedItems.Count > 0)
            {
                foreach (string MyItem in List_Source.SelectedItems)
                {
                    List_Dest.Items.Add(MyItem);
                }

                for (int MyItemIndex = List_Source.SelectedItems.Count - 1; MyItemIndex >= 0; MyItemIndex--)
                {
                    //List_Source.Items.Remove(List_Source.SelectedItems[MyItemIndex]);
                    List_Source.Items.RemoveAt(List_Source.SelectedIndices[MyItemIndex]);
                }
            }
            else
            {
                MessageBox.Show("선택된 항목이 없습니다.");
            }

        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (List_Dest.SelectedItems.Count > 0)
            {
                foreach (string MyItem in List_Dest.SelectedItems)
                {
                    List_Source.Items.Add(MyItem);
                }

                for (int MyItemIndex = List_Dest.SelectedItems.Count - 1; MyItemIndex >= 0; MyItemIndex--)
                {
                    List_Dest.Items.RemoveAt(List_Dest.SelectedIndices[MyItemIndex]);
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string SearchItem;
            int Index;

            SearchDialog SDFrom = new SearchDialog();
            SDFrom.Text = "상품검색";

            if (SDFrom.ShowDialog() == DialogResult.OK)
            {
                SearchItem = SDFrom.Txt_Serch.Text;
                Index = List_Source.Items.IndexOf(SearchItem);

                List_Source.ClearSelected();

                if (Index > -1)
                {
                    List_Source.SetSelected(Index, true);
                }
                else
                {
                    MessageBox.Show("찾을 수 없습니다.", "찾기 실패.");
                }
            }
        }
    }
}
