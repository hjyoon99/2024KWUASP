namespace _24_1posteamproj
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderLog = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.serverLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_curTime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderLog
            // 
            this.orderLog.Location = new System.Drawing.Point(22, 322);
            this.orderLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.orderLog.Multiline = true;
            this.orderLog.Name = "orderLog";
            this.orderLog.ReadOnly = true;
            this.orderLog.Size = new System.Drawing.Size(964, 550);
            this.orderLog.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(22, 122);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(217, 120);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "메뉴 관리";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(271, 120);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(217, 120);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "재고 관리";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(518, 120);
            this.btnSales.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(217, 120);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "매출 관리";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(771, 120);
            this.btnMember.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(217, 120);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "회원 관리";
            this.btnMember.UseVisualStyleBackColor = true;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(1075, 182);
            this.btnOnOff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(364, 58);
            this.btnOnOff.TabIndex = 5;
            this.btnOnOff.Text = "서버 열기";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1072, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "현재 시간:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(1296, 118);
            this.txtTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(160, 24);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "오후 11:07:02";
            // 
            // serverLog
            // 
            this.serverLog.Location = new System.Drawing.Point(1075, 322);
            this.serverLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serverLog.Multiline = true;
            this.serverLog.Name = "serverLog";
            this.serverLog.ReadOnly = true;
            this.serverLog.Size = new System.Drawing.Size(361, 550);
            this.serverLog.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "응소실 POS";
            // 
            // timer_curTime
            // 
            this.timer_curTime.Tick += new System.EventHandler(this.timer_curTime_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "server log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "order log";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(1196, 62);
            this.txtDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(269, 24);
            this.txtDate.TabIndex = 16;
            this.txtDate.Text = "2024년 6월 12일 수요일";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 900);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverLog);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.orderLog);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainForm";
            this.Text = "메인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderLog;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.TextBox serverLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_curTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtDate;
    }
}

