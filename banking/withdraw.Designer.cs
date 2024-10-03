namespace banking
{
    partial class withdraw
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
            with = new Button();
            amt = new TextBox();
            Amount = new Label();
            SuspendLayout();
            // 
            // with
            // 
            with.Location = new Point(296, 242);
            with.Name = "with";
            with.Size = new Size(126, 46);
            with.TabIndex = 5;
            with.Text = "Withdraw";
            with.UseVisualStyleBackColor = true;
            with.Click += with_Click;
            // 
            // amt
            // 
            amt.Font = new Font("Segoe UI", 15F);
            amt.Location = new Point(270, 125);
            amt.Name = "amt";
            amt.Size = new Size(300, 41);
            amt.TabIndex = 4;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI", 20F);
            Amount.ForeColor = SystemColors.ControlLightLight;
            Amount.Location = new Point(84, 125);
            Amount.Name = "Amount";
            Amount.Size = new Size(141, 46);
            Amount.TabIndex = 3;
            Amount.Text = "Amount";
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(with);
            Controls.Add(amt);
            Controls.Add(Amount);
            Name = "withdraw";
            Size = new Size(655, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button with;
        private TextBox amt;
        private Label Amount;
    }
}
