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
            this.orderLog.Location = new System.Drawing.Point(12, 161);
            this.orderLog.Multiline = true;
            this.orderLog.Name = "orderLog";
            this.orderLog.ReadOnly = true;
            this.orderLog.Size = new System.Drawing.Size(521, 277);
            this.orderLog.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 61);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(117, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "메뉴 관리";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(146, 60);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(117, 60);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "재고 관리";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(279, 60);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(117, 60);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "매출 관리";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(415, 60);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(117, 60);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "회원 관리";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(579, 91);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(196, 29);
            this.btnOnOff.TabIndex = 5;
            this.btnOnOff.Text = "서버 열기";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "현재 시간:";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(698, 59);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(77, 12);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "오후 11:07:02";
            // 
            // serverLog
            // 
            this.serverLog.Location = new System.Drawing.Point(579, 161);
            this.serverLog.Multiline = true;
            this.serverLog.Name = "serverLog";
            this.serverLog.ReadOnly = true;
            this.serverLog.Size = new System.Drawing.Size(196, 277);
            this.serverLog.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
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
            this.label4.Location = new System.Drawing.Point(577, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "server log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "order log";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(644, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(131, 12);
            this.txtDate.TabIndex = 16;
            this.txtDate.Text = "2024년 6월 12일 수요일";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
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

