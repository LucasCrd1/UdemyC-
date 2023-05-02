using ExFix.Entities;
using System.Globalization;

namespace ExFix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or impoted (c/u/i): ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture Date: (DD/MM/YYYY): ");
                    DateTime manufDate = Convert.ToDateTime(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");

            foreach (Product prd in list)
            {
                Console.WriteLine(prd.PriceTag());
            }
        }
    }
}