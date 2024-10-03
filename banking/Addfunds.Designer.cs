namespace banking
{
    partial class Addfunds
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
            Amount = new Label();
            amt = new TextBox();
            ADD = new Button();
            SuspendLayout();
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Segoe UI", 20F);
            Amount.ForeColor = SystemColors.ControlLightLight;
            Amount.Location = new Point(60, 118);
            Amount.Name = "Amount";
            Amount.Size = new Size(141, 46);
            Amount.TabIndex = 0;
            Amount.Text = "Amount";
            // 
            // amt
            // 
            amt.Font = new Font("Segoe UI", 15F);
            amt.Location = new Point(246, 118);
            amt.Name = "amt";
            amt.Size = new Size(300, 41);
            amt.TabIndex = 1;
            // 
            // ADD
            // 
            ADD.Location = new Point(272, 235);
            ADD.Name = "ADD";
            ADD.Size = new Size(126, 46);
            ADD.TabIndex = 2;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // Addfunds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(ADD);
            Controls.Add(amt);
            Controls.Add(Amount);
            Name = "Addfunds";
            Size = new Size(655, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Amount;
        private TextBox amt;
        private Button ADD;
    }
}
