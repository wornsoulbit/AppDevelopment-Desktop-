
namespace Account {
    class Program {
        static void Main(string[] args)
        {
            Account accountOne = new Account("4526", 8652);
            accountOne.DisplayAccount();
            accountOne.Credit(100);
            accountOne.DisplayAccount();
            accountOne.Debit(200);
            accountOne.DisplayAccount();

            AccountSavings savingsAccount = new AccountSavings("2554", 1500, 2);
            savingsAccount.DisplayAccount();
            savingsAccount.AccBal += savingsAccount.calcInterest();
            savingsAccount.DisplayAccount();

            AccountChecking checkingAccount = new AccountChecking("5464", 3540, 200);
            checkingAccount.DisplayAccount();
            checkingAccount.Credit(1000);
            checkingAccount.DisplayAccount();
            checkingAccount.Debit(300);
            checkingAccount.DisplayAccount();
        }
    }
}
