using System;
using Extension;
using WorkingDays.Exception;
using System.Globalization;

namespace DiasUteis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculate working days (monday - friday) between dates");
                Console.WriteLine();

                DateTime calculate = new DateTime();

                Console.WriteLine("Type start date (dd/MM/yyyy): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.WriteLine("Type finish date (dd/MM/yyyy): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.WriteLine($"Working days between {start.ToShortDateString()} and {finish.ToShortDateString()}: " + calculate.CalculateWorkingDays(start, finish) + " days.");
                
            }
            catch (DomainException d)
            {
                Console.WriteLine("Error in DateTimeExtension: " + d.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Format error: " + f.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
