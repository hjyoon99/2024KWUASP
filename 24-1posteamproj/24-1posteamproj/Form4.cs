using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace _24_1posteamproj
{
    public partial class MemberForm : Form
    {
        bool isName = false;
        bool isPhone = false;
        bool isSelected = false;
        DataTable dt = new DataTable();
        public MemberForm()
        {
            InitializeComponent();
        }
        private void HandleCreateBtn(object sender, EventArgs e)
        {
            if(phoneInput.Text.Length != 13)
            {
                MessageBox.Show("전화번호를 정확히 입력해주세요.");
                return;
            }
            DataRow dr = dt.NewRow();
            dr["NUMBER"] = dt.Rows.Count + 1;
            dr["NAME"] = nameInput.Text;
            dr["PHONE"] = phoneInput.Text;
            dr["POINT"] = "0";
            dt.Rows.Add(dr);
            dt.AcceptChanges();
            writeXml();
            LoadXml();
            MessageBox.Show(dt.Rows[dt.Rows.Count - 1][1].ToString()+" 회원의 정보를 생성했습니다.");
            SyncListView();
        }
        private void HandleDeletBtn(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                MessageBox.Show("삭제할 회원 정보를 선택해주세요.");
                return;
            }
            DataRow dr = dt.NewRow();
            int targetNumber = lvMember.SelectedItems[0].Index;
            dr = dt.Rows[targetNumber];
            dt.Rows.Remove(dr);
            MessageBox.Show("삭제가 완료되었습니다.");
            nameInput.Text = "";
            phoneInput.Text = "";
            dt.AcceptChanges();
            writeXml();
            LoadXml();
            SyncListView();
        }
        private void HandleEditBtn(object sender, EventArgs e)
        {
            if(!isPhone && !isName)
            {
                MessageBox.Show("수정할 정보를 입력해주세요.");
                return;
            }
            DataRow dr = dt.NewRow();
            int targetNumber = lvMember.SelectedItems[0].Index;
            dr = dt.Rows[targetNumber];
            if (isName)
            {
                dr["NAME"] = nameInput.Text;
            }
            if (isPhone)
            {
                dr["PHONE"] = phoneInput.Text;
            }
            dt.AcceptChanges();
            writeXml();
            LoadXml();
            SyncListView();
            MessageBox.Show("수정이 완료되었습니다.");
            nameInput.Text = "";
            phoneInput.Text = "";
        }
        private void HandleFindBtn(object sender, EventArgs e)
        {
            string query = "";
            if(isPhone && isName) {
               query = "[NAME] LIKE '" + nameInput.Text + "' AND [PHONE] LIKE '%" + phoneInput.Text + "%'";
            }
            else if(isPhone)
            {
                query = "[PHONE] LIKE '%"+phoneInput.Text+"%'";
            }
            else if(isName)
            {
                query = "[NAME] LIKE '%" + nameInput.Text + "%'";
            }
     
            DataRow[] drs = dt.Select(query);
            if (drs.Length == 0)
            {
                MessageBox.Show("검색 결과가 없습니다.");
                return;
            }
            lvMember.BeginUpdate();
            lvMember.Items.Clear();
            foreach(DataRow row in drs)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < 4; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvMember.Items.Add(item);
            }
            lvMember.EndUpdate();
        }
        private void Phone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneInput.Text = autoHyphen(phoneInput.Text);
            phoneInput.SelectionStart = phoneInput.Text.Length;
        }
        private void Phone_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToInt64(Keys.Back)) { }
            else
            {
                e.Handled = true;
            }
        }
        public string autoHyphen(string tel)
        {
            string tmpTel = tel.Replace("-", "");
            string tel1 = string.Empty;
            string tel2 = string.Empty;
            string tel3 = string.Empty;
            string tel_total = string.Empty;


            if (tmpTel.Length >= 2 && tmpTel.Length < 8)
            {
                if (tmpTel.Substring(0, 2) != "02")
                {
                    if (tmpTel.Length == 3)
                    {
                        tel_total = tmpTel + "-";
                    }
                    else if (tmpTel.Length > 3 && tmpTel.Length < 6)
                    {
                        tel1 = tmpTel.Substring(0, 3);
                        tel2 = tmpTel.Substring(3, tmpTel.Length - 3);
                        tel_total = tel1 + "-" + tel2;
                    }
                    else if (tmpTel.Length > 3 && tmpTel.Length > 6)
                    {
                        tel1 = tmpTel.Substring(0, 3);
                        tel2 = tmpTel.Substring(3, 3);
                        tel3 = tmpTel.Substring(6, tmpTel.Length - 6);
                        tel_total = tel1 + "-" + tel2 + "-" + tel3;
                    }
                    else
                    {
                        tel_total = tel;
                    }
                }
                else
                {
                    if (tmpTel.Length == 2)
                    {
                        tel_total = tmpTel + "-";
                    }
                    else if (tmpTel.Length > 2 && tmpTel.Length < 6)
                    {
                        tel1 = tmpTel.Substring(0, 2);
                        tel2 = tmpTel.Substring(2, tmpTel.Length - 2);
                        tel_total = tel1 + "-" + tel2;
                    }
                    else if (tmpTel.Length > 2 && tmpTel.Length > 5)
                    {
                        tel1 = tmpTel.Substring(0, 2);
                        tel2 = tmpTel.Substring(2, 3);
                        tel3 = tmpTel.Substring(5, tmpTel.Length - 5);
                        tel_total = tel1 + "-" + tel2 + "-" + tel3;
                    }


                }
            }
            else if (tmpTel.Length == 8 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 3);
                tel3 = tmpTel.Substring(3, 3);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 8 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 4);
                tel2 = tmpTel.Substring(4, 4);
                tel_total = tel1 + "-" + tel2;
            }
            else if (tmpTel.Length == 9 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 3);
                tel3 = tmpTel.Substring(5, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 9 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 4);
                tel3 = tmpTel.Substring(7, 2);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 10 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 4);
                tel3 = tmpTel.Substring(6, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 10 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 3);
                tel3 = tmpTel.Substring(6, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 11)
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 4);
                tel3 = tmpTel.Substring(7, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else
            {
                tel_total = tmpTel;
            }
            return tel_total;

        }
        private void Name_OnlyString(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void WhenTextChanged(object sender, EventArgs e)
        {
            if(nameInput.Text.Length == 0)
            {
                isName = false;
            }
            else
            {
                isName=true;
            }
            if(phoneInput.Text.Length == 0)
            {
                isPhone = false;
            }
            else
            {
                isPhone=true;
            }
            if(isName && isPhone)
            {
                btnCreate.Enabled = true;
            }else if(isPhone || isName)
            {
                btnSearch.Enabled = true;
                btnCreate.Enabled = false;
            }else if(!isPhone && !isName)
            {
                btnSearch.Enabled=false;
                btnCreate.Enabled=false;
                SyncListView();
            }
        }
        private void WhenItemSelected(object sender, EventArgs e)
        {
            if(lvMember.SelectedItems.Count != 0)
            {
                isSelected = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                isSelected = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled=false;
            }
        }
        private void openMainForm(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SyncListView()
        {
            lvMember.BeginUpdate();
            lvMember.Items.Clear();
            foreach(DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for(int i = 1; i < 4; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvMember.Items.Add(item);
            }
            lvMember.EndUpdate();
        }
        private void LoadXml()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Directory.GetCurrentDirectory() + @"\members.xml");
            dt = ds.Tables["MEMBER"];
        }
        private void writeXml()
        {
            dt.WriteXml(Directory.GetCurrentDirectory() + @"\members.xml");
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadXml();
            SyncListView();
            timer1.Start();
        }
        public void timer_curTime_Tick(object sender, EventArgs e)
        {

            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
