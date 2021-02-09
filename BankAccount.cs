using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {

        public BankAccount() 
        {
        }

        private double balance = 0; // Private field no use for get; or set; they are used in properties

        //Encapsulation method (hiding information)

        public void Deposit(double amount)
        {
            balance = amount;
        }

        // Will return the amount stored in balance
        public double GetBalance()
        {
            return balance;
        }


    }             
}
