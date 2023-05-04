using ExResolv.Entities;
using ExResolv.Entities.Enums;
using System.Globalization;

namespace ExResolv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                    Console.WriteLine();
                }

            }

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}