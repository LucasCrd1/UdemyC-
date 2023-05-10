using Ex_Proposto.Entities;
using Ex_Proposto.Entities.Exceptions;
using System;
using System.Globalization;

namespace Ex_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter the amount for withdraw: ");
                double withDraw = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withDraw);

                Console.WriteLine(account);

            }
			catch (DomainException e)
			{
                Console.WriteLine("Error: " + e.Message);
			}
        }
    }
}