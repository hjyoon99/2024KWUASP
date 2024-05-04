using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_1kioskteamproj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public event EventHandler<int> InformationSent;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            int information = 1;
            InformationSent?.Invoke(this, information);
            this.Close();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            int information = 2;
            InformationSent?.Invoke(this, information);
            this.Close();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int information = 3;
            InformationSent?.Invoke(this, information);
            this.Close();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int information = 4;
            InformationSent?.Invoke(this, information); this.Close();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            int information = 10;
            InformationSent?.Invoke(this, information); this.Close();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            int information = 5;
            InformationSent?.Invoke(this, information); this.Close();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            int information = 6;
            InformationSent?.Invoke(this, information); this.Close();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            int information = 7;
            InformationSent?.Invoke(this, information); this.Close();

        }

        private void b8_Click(object sender, EventArgs e)
        {
            int information = 8;
            InformationSent?.Invoke(this, information); this.Close();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            int information = 9;
            InformationSent?.Invoke(this, information); this.Close();
        }
    }
}
