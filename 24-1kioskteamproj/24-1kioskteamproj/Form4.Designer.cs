namespace _24_1kioskteamproj
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.purbox = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "결제하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purbox
            // 
            this.purbox.Location = new System.Drawing.Point(20, 245);
            this.purbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.purbox.Multiline = true;
            this.purbox.Name = "purbox";
            this.purbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.purbox.Size = new System.Drawing.Size(891, 959);
            this.purbox.TabIndex = 1;
            this.purbox.WordWrap = false;
            this.purbox.TextChanged += new System.EventHandler(this.purbox_TextChanged);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(619, 66);
            this.home.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(187, 110);
            this.home.TabIndex = 2;
            this.home.Text = "HOME\r\n";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 1256);
            this.Controls.Add(this.home);
            this.Controls.Add(this.purbox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form4";
            this.Text = "결제칸";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox purbox;
        private System.Windows.Forms.Button home;
    }
}