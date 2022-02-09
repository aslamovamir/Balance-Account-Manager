using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
  Written by: Amir Aslamov [02/08/2022 9:17 PM EST, Tampa, FL, USA]
  Program Description: This program is written to simulate the checking account manager in a dashboard form. The program shows the GUI in the form of Windows Forms and switches
                       between several forms depending on what the user selects to do in the main form - Dashboard Form: either Deposit Money, Withdraw Money, or Check His/Her Balance.
                       The program validates each input at every point of the program and makes sure the transaction requests can be successfully completed or not. The program uses
                       MessageBox class to show the corresponding messages to the user at each step of the processes.
*/

namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        //once the Dashboard form is loaded, we want to have the Checkbook object setup
        //including the 100 dollar deposit, which of couse is taken care of by the constructor of its class
        Checkbook UserAccount = new Checkbook();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Deposit_BTN_Click(object sender, EventArgs e)
        {
            //when the deposit button is clicked, we show the deposit form in dialogue mode
            //first, create the instance of the form class
            DepositForm deposit_form = new DepositForm();
            //show the deposit form now
            deposit_form.ShowDialog();
            
            //if the transaction request has been successfully submitted in the deposit form, we take action here
            if (deposit_form.transection_submitted)
            {
                //at this point we have successfully stored the user-input deposit amount into the deposit form's
                //local property, we can know call the deposit method of the Checkbook class
                UserAccount.DepositMoney(deposit_form.Deposit_Amount_prty);
                //let the user know the transection has been successfully completed
                MessageBox.Show("Your deposit transection has been successfully completed!");
            }
        }

        private void Withdraw_BTN_Click(object sender, EventArgs e)
        {
            //now when the withdraw button is clicked, we want to show the withdraw form in dialogue mode
            //first, we create the instance of the form class
            WithdrawForm withdraw_form = new WithdrawForm();
            //show the withdraw form now
            withdraw_form.ShowDialog();

            //if the transaction request has been successfully submitted in the deposit form, we take action here
            if (withdraw_form.transection_submitted)
            {
                //at this point we have successfully stored the user-input withdraw amount into the withdraw form's
                //local property, we can know call the deposit method of the Checkbook class
                //let's check if we the transaction will be processed at the Checkbook class level
                if (UserAccount.WithdrawMoney(withdraw_form.Withdraw_Amount_prty))
                {
                    //let the user know the transection has been successfully completed
                    MessageBox.Show("Your withdraw transection has been successfully completed!");
                }
                else
                {
                    MessageBox.Show("Error! The withdrawal amount is greater than the current balance! Your withdrawal transaction has been cancelled.");
                }
            }
        }

        private void Check_BTN_Click(object sender, EventArgs e)
        {
            //now when the check button is clicked, we want to show the check balance form in dialogue mode
            //first, we create the instance of the form class
            CheckBalanceForm check_form = new CheckBalanceForm(UserAccount);
            //show the withdraw form now
            check_form.ShowDialog();
        }
    }
}
