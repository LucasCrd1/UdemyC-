using Heranca_A1.Entities;

namespace Heranca_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Bob", 500.0, 0.01);

            acc1.Withdraw(10.0);  // Desconta 5.0 do método withdraw sendo um conta normal
            acc2.Withdraw(10.0);  // Não desconta 5.0 do método withdraw, pois o mesmo dendro dessa subclasse foi sobrescrito

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}