using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank {
    class BankLib {
        [Serializable]
        public class RecordSerializable {
            public int Account { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public decimal Balance { get; set; }

            public RecordSerializable() : this(0, string.Empty, string.Empty, 0M)
            {

            }

            public RecordSerializable(int accountNum, string firstName, string lastName, decimal balance)
            {
                Account = accountNum;
                FirstName = firstName;
                LastName = lastName;
                Balance = balance;
            }
        }
    }
}
