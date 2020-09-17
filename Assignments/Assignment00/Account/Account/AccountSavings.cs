using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class AccountSavings : Account {

        private decimal interestRate;

        /// <summary>
        /// Default constructor for AccountSavings, taking accNum, accBal and interestRate. 
        /// </summary>
        /// <param name="accNum"></param> Number of the account.
        /// <param name="accBal"></param> Balance of the account.
        /// <param name="interestRate"></param> Interest rate of the account.
        public AccountSavings(string accNum, decimal accBal, decimal interestRate) : base(accNum, accBal)
        {
            this.interestRate = interestRate;
        }

        /// <summary>
        /// Adds a given amount to the acccount.
        /// </summary>
        /// <param name="amount"></param> Amount to be added.
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
        }

        /// <summary>
        /// Removes a given amount from a account if there's enough money in the account.
        /// </summary>
        /// <param name="amount"></param> Amount to be removed from the account.
        /// <returns></returns> If it was successful or not.
        public override bool Debit(decimal amount)
        {
            return base.Debit(amount);
        }

        /// <summary>
        /// Calculates the interest on a account's balance.
        /// </summary>
        /// <returns></returns> The interest on the account's balance.
        public decimal calcInterest()
        {
            return (interestRate / 100) * AccBal;
        }

        /// <summary>
        /// Displays the account number, balance and the interest rate.
        /// </summary>
        public override void DisplayAccount()
        {
            string rFormattedAccNum = String.Format("| Account Number:   |{0,-20:}|", AccNum);
            string rFormattedAccBal = String.Format("| Account Balance:  |{0,20:C}|", AccBal);
            string rFormattedInterestRate = String.Format("| Interest Rate:    |{0,20:C}|", calcInterest());
            Console.WriteLine("__________________________________________");
            Console.WriteLine("|{0, 27}{1,14}", "Savings Account", "|");
            Console.WriteLine($"|________________________________________|");
            Console.WriteLine(rFormattedAccNum);
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine(rFormattedAccBal);
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine(rFormattedInterestRate);
            Console.WriteLine($"|___________________|____________________|");
        }
    }
}
