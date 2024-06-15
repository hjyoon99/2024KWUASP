using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_1posteamproj
{
    public partial class StokForm : Form
    {

        public StokForm()
        {
            InitializeComponent();
            ItemEdit.Enabled = false;

            if(NameTxt.Text!=null) ItemEdit.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer1Date.Text = DateTime.Now.ToLongDateString();
            Timer1Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog(); 

        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text != null && CountTxt.Text != null)
            {
                for(int i = 0; i < ItemList.Items.Count; i++)
                {
                    if (NameTxt.Text == ItemList.Items[i].Text)
                    {
                        ItemList.Items[i].SubItems[1].Text=CountTxt.Text;
                        ItemList.Items[i].SubItems[2].Text=OtherTxt.Text;
                    }
                }
            }
            else
            {
                /*add 수정할 예정*/
            }

            NameTxt.Text = null;
            CountTxt.Text = null;
            OtherTxt.Text = null;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            for(int i=0;i<ItemList.Items.Count; i++)
            {
             
            }
        }
    }

    
}
