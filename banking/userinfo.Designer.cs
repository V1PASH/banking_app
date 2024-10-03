namespace banking
{
    partial class userinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Accno = new Label();
            name = new Label();
            mobile = new Label();
            email = new Label();
            address = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bal = new Label();
            SuspendLayout();
            // 
            // Accno
            // 
            Accno.AutoSize = true;
            Accno.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            Accno.ForeColor = Color.WhiteSmoke;
            Accno.Location = new Point(26, 15);
            Accno.Name = "Accno";
            Accno.Size = new Size(104, 57);
            Accno.TabIndex = 0;
            Accno.Text = "info";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            name.ForeColor = Color.WhiteSmoke;
            name.Location = new Point(251, 97);
            name.Name = "name";
            name.Size = new Size(80, 35);
            name.TabIndex = 1;
            name.Text = "name";
            // 
            // mobile
            // 
            mobile.AutoSize = true;
            mobile.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            mobile.ForeColor = Color.WhiteSmoke;
            mobile.Location = new Point(251, 149);
            mobile.Name = "mobile";
            mobile.Size = new Size(97, 35);
            mobile.TabIndex = 2;
            mobile.Text = "mobile";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            email.ForeColor = Color.WhiteSmoke;
            email.Location = new Point(253, 202);
            email.Name = "email";
            email.Size = new Size(79, 35);
            email.TabIndex = 3;
            email.Text = "email";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            address.ForeColor = Color.WhiteSmoke;
            address.Location = new Point(251, 256);
            address.Name = "address";
            address.Size = new Size(104, 35);
            address.TabIndex = 4;
            address.Text = "address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(96, 256);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 8;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(96, 202);
            label2.Name = "label2";
            label2.Size = new Size(78, 35);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(96, 149);
            label3.Name = "label3";
            label3.Size = new Size(98, 35);
            label3.TabIndex = 6;
            label3.Text = "Mobile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(96, 97);
            label4.Name = "label4";
            label4.Size = new Size(92, 35);
            label4.TabIndex = 5;
            label4.Text = "Name ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(188, 361);
            label5.Name = "label5";
            label5.Size = new Size(105, 35);
            label5.TabIndex = 10;
            label5.Text = "Balance";
            // 
            // bal
            // 
            bal.AutoSize = true;
            bal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            bal.ForeColor = Color.WhiteSmoke;
            bal.Location = new Point(343, 361);
            bal.Name = "bal";
            bal.Size = new Size(86, 35);
            bal.TabIndex = 9;
            bal.Text = "label6";
            // 
            // userinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            Controls.Add(label5);
            Controls.Add(bal);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(address);
            Controls.Add(email);
            Controls.Add(mobile);
            Controls.Add(name);
            Controls.Add(Accno);
            Name = "userinfo";
            Size = new Size(655, 412);
            Load += userinfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Accno;
        private Label name;
        private Label mobile;
        private Label email;
        private Label address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label bal;
    }
}
