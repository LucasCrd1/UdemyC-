using Ex_Fixacao.Entities;
using System;
using System.Globalization;

namespace Ex_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or Company? (i/c): ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else 
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = Convert.ToInt32(Console.ReadLine());
                    list.Add(new Company(numberEmployees, name, anualIncome));
                }

                Console.WriteLine();
            }

            double TotalTaxes = 0;

            Console.WriteLine("TAXES PAID:");
            foreach (Taxpayer taxpayer in list)
            {
                TotalTaxes += taxpayer.Tax();
                Console.WriteLine(taxpayer.Name + ": $ " + taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $" + TotalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}