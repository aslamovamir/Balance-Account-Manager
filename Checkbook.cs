using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Checkbook Class File
//This class will represent the balance of a user and will hold the attribute of balance amount
namespace WindowsFormsApp2
{
    //make the class public to be able to access it from the Forms files
    public class Checkbook
    {
        //one attribute holding the current balance of the account
        //store it in decimal type for greater precision in financial transactions
        private decimal balance;

        //Constructor
        public Checkbook()
        {
            //once the account is created, 100 dollors is automatically deposited
            this.balance = 100.0M;
        }

        //let's also create a property to access the balance
        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        //let's create a deposit method
        public void DepositMoney(decimal deposit_amount)
        {
            //add the deposit amount to the curret balance
            this.balance += deposit_amount;
        }

        //let's create a withdraw method
        //we will make the return type boolean to let other methods in forms know if
        //the withdrawal has been successful, so they can let the user know of this in the panel
        public bool WithdrawMoney(decimal withdraw_amount)
        {
            //we will have to validate the transaction first: the withdrawal amount 
            //must not be greater than the current balance
            if (this.balance - withdraw_amount < 0)
            {
                Console.WriteLine("ERROR! The withdrawal amount is greater than the balance! Transection cancelled!");
                return false;
            } else
            {
                this.balance -= withdraw_amount;
                return true;
            }
        }

        //let's now create the check method
        public void CheckMyBalance()
        {
            Console.WriteLine("Your current balance is: $" + this.balance);
        }
    }
}
