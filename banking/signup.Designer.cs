namespace banking
{
    partial class signup
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sign = new Button();
            email = new TextBox();
            name = new TextBox();
            address = new TextBox();
            mobile = new TextBox();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(label7);
            mainpanel.Controls.Add(label6);
            mainpanel.Controls.Add(label5);
            mainpanel.Controls.Add(label4);
            mainpanel.Controls.Add(label3);
            mainpanel.Controls.Add(label2);
            mainpanel.Controls.Add(sign);
            mainpanel.Controls.Add(email);
            mainpanel.Controls.Add(name);
            mainpanel.Controls.Add(address);
            mainpanel.Controls.Add(mobile);
            mainpanel.Controls.Add(password);
            mainpanel.Controls.Add(username);
            mainpanel.Controls.Add(label1);
            mainpanel.Location = new Point(-1, -1);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1026, 421);
            mainpanel.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(578, 248);
            label7.Name = "label7";
            label7.Size = new Size(124, 35);
            label7.TabIndex = 21;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(575, 179);
            label6.Name = "label6";
            label6.Size = new Size(133, 35);
            label6.TabIndex = 20;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(196, 250);
            label5.Name = "label5";
            label5.Size = new Size(109, 35);
            label5.TabIndex = 19;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(578, 111);
            label4.Name = "label4";
            label4.Size = new Size(78, 35);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(196, 180);
            label3.Name = "label3";
            label3.Size = new Size(98, 35);
            label3.TabIndex = 17;
            label3.Text = "Mobile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(196, 112);
            label2.Name = "label2";
            label2.Size = new Size(85, 35);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // sign
            // 
            sign.Location = new Point(458, 361);
            sign.Name = "sign";
            sign.Size = new Size(164, 46);
            sign.TabIndex = 15;
            sign.Text = "Sign Up";
            sign.UseVisualStyleBackColor = true;
            sign.Click += button1_Click;
            // 
            // email
            // 
            email.Location = new Point(740, 119);
            email.Name = "email";
            email.Size = new Size(168, 27);
            email.TabIndex = 14;
            // 
            // name
            // 
            name.Location = new Point(314, 121);
            name.Name = "name";
            name.Size = new Size(172, 27);
            name.TabIndex = 13;
            // 
            // address
            // 
            address.Location = new Point(311, 250);
            address.Name = "address";
            address.Size = new Size(175, 27);
            address.TabIndex = 12;
            // 
            // mobile
            // 
            mobile.Location = new Point(314, 180);
            mobile.Name = "mobile";
            mobile.Size = new Size(172, 27);
            mobile.TabIndex = 11;
            // 
            // password
            // 
            password.Location = new Point(740, 256);
            password.Name = "password";
            password.Size = new Size(168, 27);
            password.TabIndex = 10;
            // 
            // username
            // 
            username.Location = new Point(740, 187);
            username.Name = "username";
            username.Size = new Size(168, 27);
            username.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(425, 10);
            label1.Name = "label1";
            label1.Size = new Size(181, 57);
            label1.TabIndex = 8;
            label1.Text = "SIGNUP";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 220);
            ClientSize = new Size(1025, 418);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signup";
            Text = "signup";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Button sign;
        private TextBox email;
        private TextBox name;
        private TextBox address;
        private TextBox mobile;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}