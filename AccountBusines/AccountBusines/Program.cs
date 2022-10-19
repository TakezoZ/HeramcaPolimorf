using AccountBusines.Entities;

namespace AccountBusines
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.0);

            // BussinesAccount acc5 = (BussinesAccount)acc3;
            if (acc3 is BussinesAccount)
            {
                BussinesAccount acc5 = (BussinesAccount)acc3;
                acc4.Loan(200.0);
                Console.WriteLine("loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}