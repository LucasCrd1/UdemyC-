using System;

namespace Aula_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int n1 = Convert.ToInt32(Console.ReadLine());
				int n2 = Convert.ToInt32((Console.ReadLine()));

				int result = n1 / n2;

				Console.WriteLine(result);
			}
			catch (DivideByZeroException)
			{
                Console.WriteLine("Division by zero is not allowed!");
			}
			catch (FormatException e)
			{
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}