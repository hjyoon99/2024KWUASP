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
    public partial class MenuForm : Form
    {
        
        public MenuForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimerDate.Text = DateTime.Now.ToLongDateString();
            TimerTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Gimbab1_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab1.Text;
        }

        private void Gimbab2_Click(object sender, EventArgs e)
        {
            MenuName.Text=Gimbab2.Text;

        }

        private void Gimbab3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab3.Text;
        }

        private void Gimbab4_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab4.Text;
        }

        private void Gimbab5_Click(object sender, EventArgs e)
        {
            MenuName.Text=Gimbab5.Text;
        }

        private void Hansik1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Hansik1.Text;
        }

        private void Hansik2_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik2.Text;
        }

        private void Hansik3_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Hansik3.Text);
        }

        private void Hansik4_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Hansik4.Text);
        }

        private void Hansik5_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik5.Text;
        }

        private void Hansik6_Click(object sender, EventArgs e)
        {
            MenuName.Text =(Hansik6.Text);
        }

        private void Hansik7_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik7.Text;
        }

        private void Wf1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf1.Text;
        }

        private void Wf2_Click(object sender, EventArgs e)
        {
            MenuName.Text = Wf2.Text;
        }

        private void Wf3_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf3.Text;
        }

        private void Wf4_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf4.Text;
        }

        private void Bunsik1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Bunsik1.Text;
        }

        private void Bunsik2_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Bunsik2.Text);
        }

        private void Bunsik3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik3.Text;
        }

        private void Bunsik4_Click(object sender, EventArgs e)
        {
            MenuName.Text =(Bunsik4.Text);
        }

        private void Bunsik5_Click(object sender, EventArgs e)
        {
            MenuName.Text = (Bunsik5.Text);
        }

        private void Bunsik6_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik6.Text;
        }

        private void Bunsik7_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik7.Text;
        }

        private void Bunsik8_Click(object sender, EventArgs e)
        {
            MenuName.Text= (Bunsik8.Text);
        }

        private void Bunsik9_Click(object sender, EventArgs e)
        {MenuName.Text= (Bunsik9.Text);

        }

        private void Side1_Click(object sender, EventArgs e)
        {
            MenuName.Text= Side1.Text;
        }

        private void Side2_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Side2.Text);
        }

        private void Side3_Click(object sender, EventArgs e)
        {
            MenuName.Text=Side3.Text;
        }

        private void Side4_Click(object sender, EventArgs e)
        {
            MenuName.Text=Side4.Text;
        }

        private void Drink1_Click(object sender, EventArgs e)
        {
            MenuName.Text= Drink1.Text;
        }

        private void Drink2_Click(object sender, EventArgs e)
        {
            MenuName.Text=Drink2.Text;
        }

        private void Drink3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Drink3.Text;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string name = MenuName.Text;
            if (name != null)
            {
                if (name == Gimbab1.Text) { Gimbab1.Enabled = false; }
                if (name == Gimbab2.Text) { Gimbab2.Enabled = false; }
                if (name == Gimbab3.Text) { Gimbab3.Enabled = false; }
                if (name == Gimbab4.Text) { Gimbab4.Enabled = false; }
                if (name == Gimbab5.Text) { Gimbab5.Enabled = false; }

                if (name == Hansik1.Text) { Hansik1.Enabled = false; }
                if (name == Hansik2.Text) { Hansik2.Enabled = false; }
                if (name == Hansik3.Text) { Hansik3.Enabled = false; }
                if (name == Hansik4.Text) { Hansik4.Enabled = false; }
                if (name == Hansik5.Text) { Hansik5.Enabled = false; }
                if (name == Hansik6.Text) { Hansik6.Enabled = false; }
                if (name == Hansik7.Text) { Hansik7.Enabled = false; }

                if (name == Wf1.Text) { Wf1.Enabled = false; }
                if (name == Wf2.Text) { Wf2.Enabled = false; }
                if (name == Wf3.Text) { Wf3.Enabled = false; }
                if (name == Wf4.Text) { Wf4.Enabled = false; }

                if (name == Bunsik1.Text) { Bunsik1.Enabled = false; }
                if (name == Bunsik2.Text) { Bunsik2.Enabled = false; }
                if (name == Bunsik3.Text) { Bunsik3.Enabled = false; }
                if (name == Bunsik4.Text) { Bunsik4.Enabled = false; }
                if (name == Bunsik5.Text) { Bunsik5.Enabled = false; }
                if (name == Bunsik6.Text) { Bunsik6.Enabled = false; }
                if (name == Bunsik7.Text) { Bunsik7.Enabled = false; }
                if (name == Bunsik8.Text) { Bunsik8.Enabled = false; }
                if (name == Bunsik9.Text) { Bunsik9.Enabled = false; }

                if (name == Side1.Text) { Side1.Enabled = false; }
                if (name == Side2.Text) { Side2.Enabled = false; }
                if (name == Side3.Text) { Side3.Enabled = false; }
                if (name == Side4.Text) { Side4.Enabled = false; }

                if (name == Drink1.Text) { Drink1.Enabled = false; }
                if (name == Drink2.Text) { Drink2.Enabled = false; }
                if (name == Drink3.Text) { Drink3.Enabled = false; }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = MenuName.Text;

            if (name == Gimbab1.Text) { Gimbab1.Enabled = true; }
            if (name == Gimbab2.Text) { Gimbab2.Enabled = true; }
            if (name == Gimbab3.Text) { Gimbab3.Enabled = true; }
            if (name == Gimbab4.Text) { Gimbab4.Enabled = true; }
            if (name == Gimbab5.Text) { Gimbab5.Enabled = true; }
            
            if(name==Hansik1.Text) { Hansik1.Enabled = true; }
            if(name==Hansik2.Text) { Hansik2.Enabled = true; }
            if(name== Hansik3.Text) { Hansik3.Enabled = true; } 
            if(name == Hansik4.Text) { Hansik4.Enabled = true; }
            if(name==Hansik5.Text) { Hansik5.Enabled = true; }
            if(name==Hansik6.Text) { Hansik6.Enabled = true; }
            if(name==Hansik7.Text) { Hansik7.Enabled = true; }
            
            if(name==Wf1.Text) { Wf1.Enabled = true; }
            if(name==Wf2.Text) { Wf2.Enabled = true; }
            if(name==Wf3.Text) { Wf3.Enabled = true; }
            if(name==Wf4.Text) { Wf4.Enabled = true; }

            if (name == Bunsik1.Text) { Bunsik1.Enabled = true; }
            if(name==Bunsik2.Text) { Bunsik2.Enabled = true; }
            if (name == Bunsik3.Text) { Bunsik3.Enabled = true; }
            if (name == Bunsik4.Text) { Bunsik4.Enabled = true; }
            if(name==Bunsik5.Text) { Bunsik5.Enabled = true; }
            if(name == Bunsik6.Text) { Bunsik6.Enabled = true; }
            if (name == Bunsik7.Text) { Bunsik7.Enabled = true; }
            if (name == Bunsik8.Text) { Bunsik8.Enabled = true; }
            if(name==Bunsik9.Text) { Bunsik9.Enabled = true; }

            if(name==Side1.Text) { Side1.Enabled = true; }
            if(name==Side2.Text) { Side2.Enabled = true; }
            if (name == Side3.Text) { Side3.Enabled = true; }
            if(name==Side4.Text) { Side4.Enabled = true; }
            
            if(name==Drink1.Text) { Drink1.Enabled = true; }
            if(name==Drink2.Text) { Drink2.Enabled = true; }
            if (name == Drink3.Text) { Drink3.Enabled = true; }

        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }
    }
}
