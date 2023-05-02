using ExResolvido.Entities;
using System;
using System.Globalization;

namespace ExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}