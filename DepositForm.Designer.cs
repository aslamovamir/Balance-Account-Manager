namespace WindowsFormsApp2
{
    partial class DepositForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.Deposit_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label1.Location = new System.Drawing.Point(241, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Deposit Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(176, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount to Deposit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(177, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Want to Go Back to Dashboard?";
            // 
            // Deposit_BTN
            // 
            this.Deposit_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Deposit_BTN.Location = new System.Drawing.Point(404, 220);
            this.Deposit_BTN.Name = "Deposit_BTN";
            this.Deposit_BTN.Size = new System.Drawing.Size(75, 32);
            this.Deposit_BTN.TabIndex = 3;
            this.Deposit_BTN.Text = "Submit";
            this.Deposit_BTN.UseVisualStyleBackColor = true;
            this.Deposit_BTN.Click += new System.EventHandler(this.Deposit_BTN_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(452, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deposit_TB
            // 
            this.Deposit_TB.Location = new System.Drawing.Point(404, 167);
            this.Deposit_TB.Name = "Deposit_TB";
            this.Deposit_TB.Size = new System.Drawing.Size(163, 20);
            this.Deposit_TB.TabIndex = 5;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deposit_TB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deposit_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Deposit_BTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Deposit_TB;
    }
}