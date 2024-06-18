/*using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _24_1kioskteamproj
{
    public partial class Form5 : Form
    {
        private int totalAmount;
        private Form2 form2;

        public Form5(int totalAmount, Form2 form2)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
            this.form2 = form2;
        }

        private void checkMemberButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            CheckMemberAndProcess(phoneNumber);
        }

        private void CheckMemberAndProcess(string phoneNumber)
        {
            var member = GetMemberByPhoneNumber(phoneNumber);

            if (member != null)
            {
                resultLabel.Text = $"이름: {member.Name}, 포인트: {member.Points} 점";
                AddPointsToMember(member);
                MessageBox.Show("포인트가 적립되었습니다.");
            }
            else
            {
                var result = MessageBox.Show("회원 정보가 없습니다. 회원가입 하시겠습니까?", "회원가입", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RegisterNewMember(phoneNumber);
                    resultLabel.Text = "회원가입이 완료되었습니다.";
                }
            }

            // 전화번호를 서버로 전송
            SendDataToServer("127.0.0.1", 12345, $"PHONE_NUMBER:{phoneNumber}");

            // Form2의 메뉴 정보를 서버로 전송
            string orderData = form2.ListViewToString(form2.listView1);
            SendDataToServer("127.0.0.1", 12345, $"ORDER_DATA:{orderData}");
        }

        private void SendDataToServer(string serverIp, int serverPort, string data)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                    stream.Write(dataBytes, 0, dataBytes.Length);
                    MessageBox.Show("데이터가 서버로 전송되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버와 통신 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private Member GetMemberByPhoneNumber(string phoneNumber)
        {
            using (var connection = new SqlConnection("Server=localhost;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Members WHERE PhoneNumber = @PhoneNumber", connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Member
                        {
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Name = reader["Name"].ToString(),
                            Points = int.Parse(reader["Points"].ToString())
                        };
                    }
                }
            }
            return null;
        }

        private void AddPointsToMember(Member member)
        {
            int pointsToAdd = CalculatePoints();
            member.Points += pointsToAdd;

            using (var connection = new SqlConnection("Server=localhost;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Members SET Points = @Points WHERE PhoneNumber = @PhoneNumber", connection);
                command.Parameters.AddWithValue("@Points", member.Points);
                command.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                command.ExecuteNonQuery();
            }
        }

        private void RegisterNewMember(string phoneNumber)
        {
            using (var connection = new SqlConnection("Server=localhost;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Members (PhoneNumber, Name, Points) VALUES (@PhoneNumber, @Name, @Points)", connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Name", "New Member");
                command.Parameters.AddWithValue("@Points", 0);
                command.ExecuteNonQuery();
            }
        }

        private int CalculatePoints()
        {
            return totalAmount / 10;
        }
    }

    public class Member
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}*/
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _24_1kioskteamproj
{
    public partial class Form5 : Form
    {
        private int totalAmount;

        public Form5(int totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
        }

        private void checkMemberButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            SendDataToServer("127.0.0.1", 12345, "PHONE_NUMBER:" + phoneNumber);
        }

        private void SendDataToServer(string serverIp, int serverPort, string data)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                    stream.Write(dataBytes, 0, dataBytes.Length);
                    //MessageBox.Show("데이터가 서버로 전송되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버와 통신 중 오류가 발생했습니다: " + ex.Message);
            }
        }
    }
}
