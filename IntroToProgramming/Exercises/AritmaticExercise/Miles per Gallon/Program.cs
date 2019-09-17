using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_per_Gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double gallons, miles, mpg;
            Console.WriteLine("**********MPG Calculator**********\r\n");
            Console.WriteLine("" +
                "This application will calculate Miles Per Gallon.\r\n" +
                "when the user supplies the 3 of gallons the car can hold and\r\n" +
                "the # of miles that can be driven on a full tank.\r\n");

            Console.Write("How many gallons can the car hold? ");
            gallons = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many miles can it be driven on a full tank? ");
            miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            mpg = miles / gallons;
            Console.WriteLine($"Miles per gallon is {mpg}\r\n");

            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();
        }
    }
}
