namespace banking
{
    partial class login
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
            mainpanel = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            signup = new Button();
            button1 = new Button();
            password = new TextBox();
            username = new TextBox();
            pictureBox1 = new PictureBox();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(235, 222, 235);
            mainpanel.Controls.Add(pictureBox3);
            mainpanel.Controls.Add(pictureBox2);
            mainpanel.Controls.Add(signup);
            mainpanel.Controls.Add(button1);
            mainpanel.Controls.Add(password);
            mainpanel.Controls.Add(username);
            mainpanel.Location = new Point(-3, 45);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1025, 418);
            mainpanel.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9187532;
            pictureBox3.Location = new Point(298, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(103, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7847599;
            pictureBox2.Location = new Point(298, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // signup
            // 
            signup.Location = new Point(439, 329);
            signup.Name = "signup";
            signup.Size = new Size(176, 44);
            signup.TabIndex = 5;
            signup.Text = "SIGN UP";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // button1
            // 
            button1.Location = new Point(439, 265);
            button1.Name = "button1";
            button1.Size = new Size(176, 44);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15F);
            password.Location = new Point(429, 161);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(276, 41);
            password.TabIndex = 1;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 15F);
            username.Location = new Point(429, 74);
            username.Name = "username";
            username.Size = new Size(276, 41);
            username.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7598644;
            pictureBox1.Location = new Point(950, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 462);
            Controls.Add(mainpanel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button signup;
        private Button button1;
        private TextBox password;
        private TextBox username;
        private PictureBox pictureBox1;
    }
}