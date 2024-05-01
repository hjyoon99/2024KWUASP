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
    public partial class Form2 : Form
    {
        //메뉴가격
        int[] menuValue = new int[9];
        //가격 종합
        int tot;
        public Form2()
        {
            //메뉴 정리
            InitializeComponent();
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            menu1.Load(@"C:\Users\natha\g1.jpg");
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Load(@"C:\Users\natha\g2.jpg");
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Load(@"C:\Users\natha\g3.jpg");
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Load(@"C:\Users\natha\g4.jpg");
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Load(@"C:\Users\natha\g5.jpg");
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            try
            {
                pictureBox1.Load(@"C:\Users\natha\gimbab.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //메뉴정리
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            menu1.Load(@"C:\Users\natha\g1.jpg");
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Load(@"C:\Users\natha\g2.jpg");
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Load(@"C:\Users\natha\g3.jpg");
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Load(@"C:\Users\natha\g4.jpg");
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Load(@"C:\Users\natha\g5.jpg");
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            menuValue[0] = 3000;
            menuValue[1] = 4000;
            menuValue[2] = 4000;
            menuValue[3] = 4500;
            menuValue[4] = 5000;

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            
        }

        private void menu2_Click(object sender, EventArgs e)
        {

        }

        private void menu3_Click(object sender, EventArgs e)
        {

        }

        private void menu4_Click(object sender, EventArgs e)
        {

        }

        private void menu5_Click(object sender, EventArgs e)
        {

        }

        private void menu6_Click(object sender, EventArgs e)
        {

        }

        private void menu7_Click(object sender, EventArgs e)
        {

        }

        private void menu8_Click(object sender, EventArgs e)
        {

        }

        private void menu9_Click(object sender, EventArgs e)
        {

        }
    }
}
