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
        /// Calculates the interest on a account's balance.
        /// </summary>
        /// <returns></returns> The interest on the account's balance.
        public decimal calcInterest()
        {
            return interestRate * AccBal;
        }

        /// <summary>
        /// Displays the account number, balance and the interest rate.
        /// </summary>
        public override void DisplayAccount()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"|             Savings Account            |");
            Console.WriteLine($"|________________________________________|");
            Console.WriteLine($"|Account Number     |{AccNum}                |");
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine($"|Account Balance    |                {AccBal}|");
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine($"|Interest Rate      |{(interestRate / 100) * AccBal}               |");
            Console.WriteLine($"|___________________|____________________|");
        }
    }
}
