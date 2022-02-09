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
    public partial class CheckBalanceForm : Form
    {
        //create a property to get the balance of the user account object
        public decimal balance { get; set; }

        //we will paramterize the cinstructor of the form so we can pass the user account object
        //from the dashboard form
        public CheckBalanceForm(Checkbook user_account)
        {
            InitializeComponent();
            //set the property to the balance of the passed account object
            this.balance = user_account.Balance;
        }

        private void Check_BTN_Click(object sender, EventArgs e)
        {
            //just change the balance textbox value to the value of the balance property
            Balance_TB.Text = balance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //first reset the textbox value
            Balance_TB.Text = "";
            //now go back to the form that invoked this form
            this.DialogResult = DialogResult.OK;
        }
    }
}
