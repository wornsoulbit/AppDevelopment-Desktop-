using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class Program {

        class Account {
            private string accNum;
            private decimal accBal;

            public Account(string accNum, decimal accBal) 
            {
                if (accBal >= 0)
                    this.accBal = accBal;
                else
                    Console.WriteLine("The inputed number needs to be positive.");

                this.accNum = accNum;
                
            }

            public void Credit(decimal amount)
            {
                if (amount >= 0)
                    accBal += amount;
                else
                    Console.WriteLine("Please enter a positive number.");
            }

            public bool Debit(decimal amount)
            {
                if (amount < accBal)
                {
                    accBal -= amount;
                    return true;
                }
                else
                {
                    Console.WriteLine("Debit amount exceeded account balance.");
                    return false;
                }
            }

            public decimal GetAccBal()
            {
                return accBal;
            }

            public void DisplayAccount()
            {

            }
        }

        class AccountSavings : Account {

            private decimal interestRate;

            public AccountSavings(string accNum, decimal accBal, decimal interestRate) : base(accNum, accBal)
            {
                this.interestRate = interestRate;
            }

            public decimal CalculatedInterest()
            {
                return GetAccBal() * interestRate;
            }

            public void DisplayAccount()
            {

            }
        }

        class CheckingAccount : Account {

            private decimal fee;

            public CheckingAccount(String accNum, decimal accBal, decimal fee) : base(accNum, accBal)
            {
                this.fee = fee;
            }

            public void DisplayAccount()
            {

            }
        }
    }
}
