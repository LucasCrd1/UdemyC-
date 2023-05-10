using Ex_Resolvido.Entities;
using Ex_Resolvido.Entities.Exceptions;

namespace Ex_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Check-in date: (dd/MM/yyyy) ");
                DateTime checkIn = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Check-out: (dd/MM/yyyy) ");
                DateTime checkOut = Convert.ToDateTime(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter the data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = Convert.ToDateTime(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}