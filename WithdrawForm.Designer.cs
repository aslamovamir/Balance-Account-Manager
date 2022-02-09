namespace WindowsFormsApp2
{
    partial class WithdrawForm
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
            this.Withdraw_BTN = new System.Windows.Forms.Button();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Withdraw_Amount_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Withdraw_BTN
            // 
            this.Withdraw_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Withdraw_BTN.Location = new System.Drawing.Point(410, 207);
            this.Withdraw_BTN.Name = "Withdraw_BTN";
            this.Withdraw_BTN.Size = new System.Drawing.Size(75, 30);
            this.Withdraw_BTN.TabIndex = 0;
            this.Withdraw_BTN.Text = "Submit";
            this.Withdraw_BTN.UseVisualStyleBackColor = true;
            this.Withdraw_BTN.Click += new System.EventHandler(this.Withdraw_BTN_Click);
            // 
            // Back_BTN
            // 
            this.Back_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Back_BTN.Location = new System.Drawing.Point(438, 304);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(75, 33);
            this.Back_BTN.TabIndex = 1;
            this.Back_BTN.Text = "Back";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(176, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Amount to Withdraw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(166, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Want to Go Back to Dashboard?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label3.Location = new System.Drawing.Point(260, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Money Withdrawal Panel";
            // 
            // Withdraw_Amount_TB
            // 
            this.Withdraw_Amount_TB.Location = new System.Drawing.Point(410, 155);
            this.Withdraw_Amount_TB.Name = "Withdraw_Amount_TB";
            this.Withdraw_Amount_TB.Size = new System.Drawing.Size(165, 20);
            this.Withdraw_Amount_TB.TabIndex = 5;
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Withdraw_Amount_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.Withdraw_BTN);
            this.Name = "WithdrawForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Withdraw_BTN;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Withdraw_Amount_TB;
    }
}