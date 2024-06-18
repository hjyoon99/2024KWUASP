using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _24_1kioskteamproj
{
    public partial class Form5 : Form
    { //일단 DB 생성 전이므로, 반응이 없는데, 나중에 DB랑 연결해봐야알 것 같습니다.
      // 그래서 일단 영수증 발급 전으로 전화번호로 조회하는 포인트 적립 창을 넣었으나, 반응이 없으므로 그냥 X누르고 진행해주시면 됩니다.
      // 추후 DB 연결 후 재 테스트하면 될 것 같아요!

        private int totalAmount;

        public Form5(int totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
        }

        private void checkMemberButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            // DB 조회 및 포인트 적립/회원 가입 로직 호출
            CheckMemberAndProcess(phoneNumber);
        }

        private void CheckMemberAndProcess(string phoneNumber)
        {
            // DB에서 회원 정보 조회
            var member = GetMemberByPhoneNumber(phoneNumber);

            if (member != null)
            {
                // 회원이 있으면 정보를 라벨에 표시
                resultLabel.Text = $"이름: {member.Name}, 포인트: {member.Points} 점";
                AddPointsToMember(member);
                MessageBox.Show("포인트가 적립되었습니다.");
            }
            else
            {
                // 회원이 없으면 회원 가입 유도
                var result = MessageBox.Show("회원 정보가 없습니다. 회원가입 하시겠습니까?", "회원가입", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RegisterNewMember(phoneNumber);
                    resultLabel.Text = "회원가입이 완료되었습니다.";
                }
            }
        }

        private Member GetMemberByPhoneNumber(string phoneNumber)
        {
            //데이터베이스 테이블 예시입니다.

            /*
            CREATE DATABASE YourDatabaseName;
            CREATE LOGIN YourUsername WITH PASSWORD = 'YourPassword';
            CREATE USER YourUsername FOR LOGIN YourUsername;
            EXEC sp_addrolemember 'db_owner', 'YourUsername';

            USE YourDatabaseName;

            CREATE TABLE Members(
                PhoneNumber NVARCHAR(15) PRIMARY KEY,
                Name NVARCHAR(50),
                Points INT
            );
            */

            // DB 조회 로직을 구현합니다.
            using (var connection = new SqlConnection("Server=localhost;Database=데이터베이스명;User Id=유저네임;Password=비밀번호;"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Members WHERE PhoneNumber = @PhoneNumber", connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Member 객체를 생성하여 반환합니다.
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

            // DB 업데이트 로직을 구현합니다.
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
            // DB에 새로운 회원 정보를 삽입하는 로직을 구현합니다.
            using (var connection = new SqlConnection("Server=localhost;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;"))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Members (PhoneNumber, Name, Points) VALUES (@PhoneNumber, @Name, @Points)", connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Name", "New Member"); // 임시 이름 설정
                command.Parameters.AddWithValue("@Points", 0); // 초기 포인트는 0으로 설정
                command.ExecuteNonQuery();
            }
        }

        private int CalculatePoints()
        {
            // 결제 금액의 10%를 포인트로 계산
            return totalAmount / 10;
        }
    }

    public class Member
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}

