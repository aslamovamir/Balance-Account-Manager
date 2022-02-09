using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class WithdrawForm : Form
    {
        //let's create a property of deposit amount in this form
        public decimal Withdraw_Amount_prty { get; set; }
        //we will also create a boolean property to let the dashboard know 
        //if the transection request has been successfully submitted
        public bool transection_submitted { get; set; }

        public WithdrawForm()
        {
            InitializeComponent();
            //reset the tansection status to default false
            this.transection_submitted = false;
        }

        private void Withdraw_BTN_Click(object sender, EventArgs e)
        {
            //let's first validate the input to the deposit amount textbox
            if (Withdraw_Amount_TB.Text == "")
            {
                MessageBox.Show("Error! Enter withdrawal amount please!");
            }
            else
            {
                decimal input = 0;
                //let's put the parsing into a try block for security purposes
                try
                {
                    input = decimal.Parse(Withdraw_Amount_TB.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Invalid input! Please try again!");
                    Withdraw_Amount_TB.Text = "";
                    return;
                }

                if (input <= 0)
                {
                    //we dont want to withdraw 0 or negative amounts
                    MessageBox.Show("Error! Enter amount greater than 0!");
                    //reset the texbox
                    Withdraw_Amount_TB.Text = "";
                    //return the method
                    return;
                }

                //now we can safely store the valid input into the property of deposit amount
                this.Withdraw_Amount_prty = input;
                //let the user know the deposit transaction has been submitted
                MessageBox.Show("Success! The withdrawal request has been submitted. It is being processed now.");
                Withdraw_Amount_TB.Text = "";
                //set the transection status
                this.transection_submitted = true;
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            //go back to the dashboard form, which called this form
            this.DialogResult = DialogResult.OK;
        }
    }
}
