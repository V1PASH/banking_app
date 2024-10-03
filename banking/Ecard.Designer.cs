namespace banking
{
    partial class Ecard
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
            cardno = new Label();
            cvv = new Label();
            expiry = new Label();
            panel1 = new Panel();
            hiddencvv = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            name = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cardno
            // 
            cardno.AutoSize = true;
            cardno.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cardno.ForeColor = SystemColors.ButtonHighlight;
            cardno.Location = new Point(57, 64);
            cardno.Name = "cardno";
            cardno.Size = new Size(279, 46);
            cardno.TabIndex = 0;
            cardno.Text = "DEBIT CARD NO";
            // 
            // cvv
            // 
            cvv.AutoSize = true;
            cvv.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            cvv.ForeColor = SystemColors.ButtonHighlight;
            cvv.Location = new Point(375, 221);
            cvv.Name = "cvv";
            cvv.Size = new Size(60, 37);
            cvv.TabIndex = 1;
            cvv.Text = "cvv";
            cvv.Click += cvv_Click;
            // 
            // expiry
            // 
            expiry.AutoSize = true;
            expiry.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            expiry.ForeColor = SystemColors.ButtonHighlight;
            expiry.Location = new Point(57, 210);
            expiry.Name = "expiry";
            expiry.Size = new Size(99, 37);
            expiry.TabIndex = 2;
            expiry.Text = "expiry";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(hiddencvv);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cvv);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cardno);
            panel1.Controls.Add(expiry);
            panel1.Location = new Point(80, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 271);
            panel1.TabIndex = 3;
            // 
            // hiddencvv
            // 
            hiddencvv.AutoSize = true;
            hiddencvv.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            hiddencvv.ForeColor = SystemColors.ButtonHighlight;
            hiddencvv.Location = new Point(382, 221);
            hiddencvv.Name = "hiddencvv";
            hiddencvv.Size = new Size(53, 37);
            hiddencvv.TabIndex = 9;
            hiddencvv.Text = "***";
            hiddencvv.Click += hiddencvv_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(57, 13);
            label3.Name = "label3";
            label3.Size = new Size(211, 28);
            label3.TabIndex = 8;
            label3.Text = "ASHVIN FEDRAL BANK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Mastercard_logo_svg;
            pictureBox2.Location = new Point(439, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chip_removebg_preview;
            pictureBox1.Location = new Point(401, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(375, 187);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 4;
            label2.Text = "CVV";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            name.ForeColor = SystemColors.ButtonHighlight;
            name.Location = new Point(57, 132);
            name.Name = "name";
            name.Size = new Size(122, 23);
            name.TabIndex = 5;
            name.Text = "Name on card";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(57, 187);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 3;
            label1.Text = "Expiry Date";
            // 
            // Ecard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(panel1);
            Name = "Ecard";
            Size = new Size(655, 412);
            Load += Ecard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label cardno;
        private Label cvv;
        private Label expiry;
        private Panel panel1;
        private Label name;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label hiddencvv;
    }
}
