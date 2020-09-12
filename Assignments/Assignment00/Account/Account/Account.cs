using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class Account {
        private string accNum;
        private decimal accBal;

        /// <summary>
        /// Default Constructor for Account, taking an account number and account balance.
        /// </summary>
        /// <param name="accNum"></param> Number of the account.
        /// <param name="accBal"></param> Balance of the account.
        public Account(string accNum, decimal accBal)
        {
            if (accBal >= 0.0M)
                this.accBal = accBal;
            else
                Console.WriteLine("The inputed number needs to be positive.");

            this.accNum = accNum;

        }

        /// <summary>
        /// Adds a given amount to the acccount.
        /// </summary>
        /// <param name="amount"></param> Amount to be added.
        public virtual void Credit(decimal amount)
        {
            accBal += amount;
        }

        /// <summary>
        /// Removes a given amount from a account if there's enough money in the account.
        /// </summary>
        /// <param name="amount"></param> Amount to be removed from the account.
        /// <returns></returns> If it was successful or not.
        public virtual bool Debit(decimal amount)
        {
            if (amount > 0.0M)
            {
                accBal -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Amount input exceeds the account balance");
                return false;
            }
        }

        /// <summary>
        /// Getter, setter for accBal.
        /// </summary>
        public decimal AccBal
        {
            get { return accBal; }
            set
            {
                if (value > 0.0M)
                {
                    accBal = value;
                } 
                else
                {
                    Console.WriteLine("Amount needs to be positive");
                }
            }
        }

        /// <summary>
        /// Getter, setter for accNum.
        /// </summary>
        public string AccNum
        {
            get { return accNum; }
            set { accNum = value; }
        }

        /// <summary>
        /// Displays the account number and balance.
        /// </summary>
        public virtual void DisplayAccount()
        { 
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"|                 Account                |");
            Console.WriteLine($"|________________________________________|");
            Console.WriteLine($"|Account Number     |{accNum}                |");
            Console.WriteLine($"|___________________|____________________|");
            Console.WriteLine($"|Account Balance    |                {accBal}|");
            Console.WriteLine($"|___________________|____________________|");
        }
    }
}
