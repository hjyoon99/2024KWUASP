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
            string points = SendDataToServer("127.0.0.1", 12345, "PHONE_NUMBER:" + phoneNumber);
            if (points == "Member not found")
            {
                MessageBox.Show("회원 정보를 찾을 수 없습니다.");
            }
            else
            {
                int currentPoints = int.Parse(points); // points를 int로 변환
                int earnedPoints = totalAmount / 10;
                int totalPoints = currentPoints + earnedPoints;

                MessageBox.Show($"전화번호 {phoneNumber}의 데이터가 서버로 전송되었습니다.\n총 금액: {totalAmount}원\n포인트 적립: {earnedPoints}원\n총 포인트 : {totalPoints}");
                pointLabel.Text = $"포인트: {totalPoints} 점";
            }
        }

        private string SendDataToServer(string serverIp, int serverPort, string data)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIp, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                    stream.Write(dataBytes, 0, dataBytes.Length);

                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    return Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버와 통신 중 오류가 발생했습니다: " + ex.Message);
                return null;
            }
        }
    }
}
