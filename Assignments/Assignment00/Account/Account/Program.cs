
namespace Account {
    class Program {
        static void Main(string[] args)
        {
            Account obj3 = new Account("4526", 8652);
            obj3.DisplayAccount();

            AccountSavings obj1 = new AccountSavings("2554", 1500, 2);
            obj1.Debit(25);
            obj1.DisplayAccount();

            AccountChecking obj2 = new AccountChecking("5464", 3540, 200);
            obj2.Credit(1000);
            obj2.Debit(302);
            obj2.DisplayAccount();
        }
    }
}
