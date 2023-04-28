using Heranca_A1.Entities;
using System;

namespace Heranca_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(102, "Lucas", 0.0);
            BusinessAccount bacc = new BusinessAccount(123, "Julia", 0.0, 1000.0);

            // Teste UPCASTING 

            Account acc1 = bacc;                                                // Conversão de um BusinessAccount para uma Account
            Account acc2 = new BusinessAccount(1234, "Bob", 0.0, 200.0); // É possível instanciar uma subclasse e atribuir essa instância para a var da superclasse
            Account acc3 = new SavingsAccount(234, "Alex", 0.0, 0.01);

            // Teste DOWNCASTING
            // É necessário testar se realmente a variável é do tipo que você precisa, para isso se usa o operador "is" ou "as"

            BusinessAccount acc4 = (BusinessAccount)acc2; // Para converter uma superclasse para subclasse, é necessário fazer um casting
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount) // O operador is se usa dessa forma / esse if vai falhar pois é do tipo SavingsAccount
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Outra forma de se fazer o casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
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