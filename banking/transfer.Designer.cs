namespace banking
{
    partial class transfer
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
            name = new Label();
            transferaccount = new TextBox();
            button1 = new Button();
            amount = new TextBox();
            transferbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 20F);
            name.ForeColor = SystemColors.Control;
            name.Location = new Point(67, 150);
            name.Name = "name";
            name.Size = new Size(138, 46);
            name.TabIndex = 0;
            name.Text = "Transfer";
            // 
            // transferaccount
            // 
            transferaccount.Font = new Font("Segoe UI", 15F);
            transferaccount.Location = new Point(303, 42);
            transferaccount.Name = "transferaccount";
            transferaccount.Size = new Size(304, 41);
            transferaccount.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(403, 99);
            button1.Name = "button1";
            button1.Size = new Size(84, 40);
            button1.TabIndex = 2;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // amount
            // 
            amount.Font = new Font("Segoe UI", 15F);
            amount.Location = new Point(303, 235);
            amount.Name = "amount";
            amount.Size = new Size(304, 41);
            amount.TabIndex = 3;
            // 
            // transferbutton
            // 
            transferbutton.Font = new Font("Segoe UI", 15F);
            transferbutton.Location = new Point(251, 342);
            transferbutton.Name = "transferbutton";
            transferbutton.Size = new Size(151, 49);
            transferbutton.TabIndex = 4;
            transferbutton.Text = "Transfer";
            transferbutton.UseVisualStyleBackColor = true;
            transferbutton.Click += transferbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(269, 35);
            label1.TabIndex = 5;
            label1.Text = "Enter Account Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 241);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 6;
            label2.Text = "Enter Amount";
            // 
            // transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transferbutton);
            Controls.Add(amount);
            Controls.Add(button1);
            Controls.Add(transferaccount);
            Controls.Add(name);
            Name = "transfer";
            Size = new Size(655, 412);
            Load += transfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private TextBox transferaccount;
        private Button button1;
        private TextBox amount;
        private Button transferbutton;
        private Label label1;
        private Label label2;
    }
}
