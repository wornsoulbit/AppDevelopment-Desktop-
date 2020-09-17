using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class AccountChecking : Account {

        private decimal fee;

        /// <summary>
        /// Default constructor for AccountChecking, taking a accNum, accBal, and fee.
        /// </summary>
        /// <param name="accNum"></param> Number of the account.
        /// <param name="accBal"></param> Balance of the account.
        /// <param name="fee"></param> Fee amount for each debit/credit transaction.
        public AccountChecking(string accNum, decimal accBal, decimal fee) : base(accNum, accBal)
        {
            this.fee = fee;
        }

        /// <summary>
        /// Removes a given amount from a account if there's enough money in the account.
        /// </summary>
        /// <param name="amount"></param> Amount to be removed from the account.
        /// <returns></returns> If it was successful or not.
        public override bool Debit(decimal amount)
        {
            if (AccBal > amount + fee)
            {
                base.Debit(amount + fee);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a given amount to the acccount.
        /// </summary>
        /// <param name="amount"></param> Amount to be added.
        public override void Credit(decimal amount)
        {
            base.Credit(amount - fee);
        }

        /// <summary>
        /// Displays the account number, balance and the transaction fee.
        /// </summary>
        public override void DisplayAccount()
        {
            string rFormattedAccNum = String.Format("| Account Number:   |{0,-20:}|", AccNum);
            string rFormattedAccBal = String.Format("| Account Balance:  |{0,20:C}|", AccBal);
            string rFormattedFee = String.Format("| Transaction Fee:  |{0,20:C}|", fee);
            Console.WriteLine("__________________________________________");
            Console.WriteLine("|{0, 27}{1,14}", "Checking Account", "|");
            Console.WriteLine($"|________________________________________|");
            Console.WriteLine(rFormattedAccNum);
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine(rFormattedAccBal);
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine(rFormattedFee);
            Console.WriteLine($"|___________________|____________________|");
        }
    }
}
