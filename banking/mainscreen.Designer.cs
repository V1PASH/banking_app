namespace banking
{
    partial class mainscreen
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            debitcard = new Label();
            label1 = new Label();
            funds = new Label();
            withdraw = new Label();
            transfer = new Label();
            info = new Label();
            withdraw2 = new withdraw();
            userinfo2 = new userinfo();
            transfer2 = new transfer();
            addfunds2 = new Addfunds();
            ecard1 = new Ecard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._7598644;
            pictureBox1.Location = new Point(746, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(120, 120, 220);
            panel1.Controls.Add(debitcard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(funds);
            panel1.Controls.Add(withdraw);
            panel1.Controls.Add(transfer);
            panel1.Controls.Add(info);
            panel1.Location = new Point(-1, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 412);
            panel1.TabIndex = 1;
            // 
            // debitcard
            // 
            debitcard.AutoSize = true;
            debitcard.BackColor = Color.Transparent;
            debitcard.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            debitcard.ForeColor = SystemColors.Control;
            debitcard.Location = new Point(10, 278);
            debitcard.Name = "debitcard";
            debitcard.Size = new Size(103, 35);
            debitcard.TabIndex = 7;
            debitcard.Text = "E CARD";
            debitcard.Click += debitcard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(10, 354);
            label1.Name = "label1";
            label1.Size = new Size(123, 35);
            label1.TabIndex = 6;
            label1.Text = "LOG OUT";
            label1.Click += label1_Click;
            // 
            // funds
            // 
            funds.AutoSize = true;
            funds.BackColor = Color.Transparent;
            funds.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            funds.ForeColor = SystemColors.Control;
            funds.Location = new Point(3, 217);
            funds.Name = "funds";
            funds.Size = new Size(139, 35);
            funds.TabIndex = 5;
            funds.Text = "Add Funds";
            funds.Click += funds_Click;
            // 
            // withdraw
            // 
            withdraw.AutoSize = true;
            withdraw.BackColor = Color.Transparent;
            withdraw.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            withdraw.ForeColor = SystemColors.Control;
            withdraw.Location = new Point(3, 160);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(130, 35);
            withdraw.TabIndex = 4;
            withdraw.Text = "Withdraw";
            withdraw.Click += withdraw_Click;
            // 
            // transfer
            // 
            transfer.AutoSize = true;
            transfer.BackColor = Color.Transparent;
            transfer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            transfer.ForeColor = SystemColors.Control;
            transfer.Location = new Point(3, 99);
            transfer.Name = "transfer";
            transfer.Size = new Size(111, 35);
            transfer.TabIndex = 4;
            transfer.Text = "Transfer";
            transfer.Click += transfer_Click;
            // 
            // info
            // 
            info.AutoSize = true;
            info.BackColor = Color.Transparent;
            info.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            info.ForeColor = SystemColors.Control;
            info.Location = new Point(3, 26);
            info.Name = "info";
            info.Size = new Size(143, 35);
            info.TabIndex = 3;
            info.Text = "USER INFO";
            info.Click += info_Click;
            // 
            // withdraw2
            // 
            withdraw2.BackColor = Color.Indigo;
            withdraw2.Location = new Point(144, 39);
            withdraw2.Name = "withdraw2";
            withdraw2.Size = new Size(656, 412);
            withdraw2.TabIndex = 2;
            // 
            // userinfo2
            // 
            userinfo2.BackColor = Color.Indigo;
            userinfo2.Location = new Point(144, 39);
            userinfo2.Name = "userinfo2";
            userinfo2.Size = new Size(656, 412);
            userinfo2.TabIndex = 3;
            // 
            // transfer2
            // 
            transfer2.BackColor = Color.Indigo;
            transfer2.Location = new Point(144, 38);
            transfer2.Name = "transfer2";
            transfer2.Size = new Size(667, 419);
            transfer2.TabIndex = 4;
            // 
            // addfunds2
            // 
            addfunds2.BackColor = Color.Indigo;
            addfunds2.Location = new Point(144, 38);
            addfunds2.Name = "addfunds2";
            addfunds2.Size = new Size(656, 413);
            addfunds2.TabIndex = 5;
            // 
            // ecard1
            // 
            ecard1.BackColor = Color.Indigo;
            ecard1.Location = new Point(145, 39);
            ecard1.Name = "ecard1";
            ecard1.Size = new Size(655, 412);
            ecard1.TabIndex = 6;
            ecard1.Load += ecard1_Load;
            // 
            // mainscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(799, 449);
            Controls.Add(ecard1);
            Controls.Add(addfunds2);
            Controls.Add(transfer2);
            Controls.Add(userinfo2);
            Controls.Add(withdraw2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainscreen";
            Load += mainscreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label withdraw;
        private Label transfer;
        private Label info;
        private Label funds;
        private userinfo userinfo1;
        private Addfunds addfunds1;
        private transfer transfer1;
        private withdraw withdraw1;
        private withdraw withdraw2;
        private userinfo userinfo2;
        private transfer transfer2;
        private Addfunds addfunds2;
        private Label label1;
        private Label debitcard;
        private Ecard ecard1;
    }
}