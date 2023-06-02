namespace studio
{
    partial class Login
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
            this.Login_loginBtn = new System.Windows.Forms.Button();
            this.Login_UserName = new System.Windows.Forms.TextBox();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_ExitBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_loginBtn
            // 
            this.Login_loginBtn.FlatAppearance.BorderSize = 2;
            this.Login_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_loginBtn.ForeColor = System.Drawing.Color.White;
            this.Login_loginBtn.Location = new System.Drawing.Point(549, 230);
            this.Login_loginBtn.Name = "Login_loginBtn";
            this.Login_loginBtn.Padding = new System.Windows.Forms.Padding(1);
            this.Login_loginBtn.Size = new System.Drawing.Size(100, 28);
            this.Login_loginBtn.TabIndex = 0;
            this.Login_loginBtn.Text = "تسجيل الدخول";
            this.Login_loginBtn.UseVisualStyleBackColor = true;
            this.Login_loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Login_UserName
            // 
            this.Login_UserName.Location = new System.Drawing.Point(429, 137);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(162, 20);
            this.Login_UserName.TabIndex = 1;
            this.Login_UserName.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            // 
            // Login_Password
            // 
            this.Login_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_Password.Location = new System.Drawing.Point(429, 178);
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(162, 20);
            this.Login_Password.TabIndex = 2;
            this.Login_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::studio.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(616, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::studio.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(616, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login_ExitBtn
            // 
            this.Login_ExitBtn.FlatAppearance.BorderSize = 0;
            this.Login_ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_ExitBtn.ForeColor = System.Drawing.Color.White;
            this.Login_ExitBtn.Location = new System.Drawing.Point(642, 0);
            this.Login_ExitBtn.Name = "Login_ExitBtn";
            this.Login_ExitBtn.Size = new System.Drawing.Size(99, 23);
            this.Login_ExitBtn.TabIndex = 5;
            this.Login_ExitBtn.Text = "اغلاق";
            this.Login_ExitBtn.UseVisualStyleBackColor = true;
            this.Login_ExitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(319, 362);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "careem studio";
            // 
            // Login_Clear
            // 
            this.Login_Clear.FlatAppearance.BorderSize = 2;
            this.Login_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Clear.ForeColor = System.Drawing.Color.White;
            this.Login_Clear.Location = new System.Drawing.Point(429, 230);
            this.Login_Clear.Name = "Login_Clear";
            this.Login_Clear.Padding = new System.Windows.Forms.Padding(1);
            this.Login_Clear.Size = new System.Drawing.Size(100, 28);
            this.Login_Clear.TabIndex = 8;
            this.Login_Clear.Text = "مسح البيانات";
            this.Login_Clear.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(742, 362);
            this.Controls.Add(this.Login_Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Login_ExitBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_UserName);
            this.Controls.Add(this.Login_loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_loginBtn;
        private System.Windows.Forms.TextBox Login_UserName;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Login_ExitBtn;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_Clear;
    }
}

