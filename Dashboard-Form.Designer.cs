namespace WindowsFormsApp2
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Deposit_BTN = new System.Windows.Forms.Button();
            this.Withdraw_BTN = new System.Windows.Forms.Button();
            this.Check_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(256, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(241, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Withdraw Money:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(210, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check Your Balance:";
            // 
            // Deposit_BTN
            // 
            this.Deposit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Deposit_BTN.Location = new System.Drawing.Point(423, 170);
            this.Deposit_BTN.Name = "Deposit_BTN";
            this.Deposit_BTN.Size = new System.Drawing.Size(75, 28);
            this.Deposit_BTN.TabIndex = 3;
            this.Deposit_BTN.Text = "Deposit";
            this.Deposit_BTN.UseVisualStyleBackColor = true;
            this.Deposit_BTN.Click += new System.EventHandler(this.Deposit_BTN_Click);
            // 
            // Withdraw_BTN
            // 
            this.Withdraw_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Withdraw_BTN.Location = new System.Drawing.Point(423, 248);
            this.Withdraw_BTN.Name = "Withdraw_BTN";
            this.Withdraw_BTN.Size = new System.Drawing.Size(75, 28);
            this.Withdraw_BTN.TabIndex = 4;
            this.Withdraw_BTN.Text = "Withdraw";
            this.Withdraw_BTN.UseVisualStyleBackColor = true;
            this.Withdraw_BTN.Click += new System.EventHandler(this.Withdraw_BTN_Click);
            // 
            // Check_BTN
            // 
            this.Check_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Check_BTN.Location = new System.Drawing.Point(423, 324);
            this.Check_BTN.Name = "Check_BTN";
            this.Check_BTN.Size = new System.Drawing.Size(75, 28);
            this.Check_BTN.TabIndex = 5;
            this.Check_BTN.Text = "Check";
            this.Check_BTN.UseVisualStyleBackColor = true;
            this.Check_BTN.Click += new System.EventHandler(this.Check_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label4.Location = new System.Drawing.Point(287, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Balance Dashbard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(117, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(572, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Welcome to your account dashboard, what would you like to do today?";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Check_BTN);
            this.Controls.Add(this.Withdraw_BTN);
            this.Controls.Add(this.Deposit_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Deposit_BTN;
        private System.Windows.Forms.Button Withdraw_BTN;
        private System.Windows.Forms.Button Check_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

