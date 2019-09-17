using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSaleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal priceStand = 45.85m, priceUpper = 67m, priceLower = 154.5m;
            int numStand, numUpper, numLower, numTotal;
            decimal valStand, valUpper, valLower, valTotal;
            Console.WriteLine("********************Hockey Tickets********************\r\n");
            Console.WriteLine("Please enter the number of tickets sold for each type.\r\n");
            Console.WriteLine("Ticker Prices are:");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Standing Room Only:\t\t{priceStand.ToString("c")} each.");
            Console.WriteLine($"Upper Bowl:\t\t\t{priceUpper.ToString("c")} each.");
            Console.WriteLine($"Lower Bowl:\t\t\t{priceLower.ToString("c")} each.");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();


            Console.Write("# Standing Room Only: ");
            numStand = Convert.ToInt32(Console.ReadLine());
            Console.Write("# Upper Bowl: ");
            numUpper = Convert.ToInt32(Console.ReadLine());
            Console.Write("# Lower Bowl: ");
            numLower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            numTotal = numStand + numLower + numUpper;
            valStand = numStand * priceStand;
            valUpper = numUpper * priceUpper;
            valLower = numLower * priceLower;
            valTotal = valStand + valUpper + valLower;


            Console.WriteLine("Ticket Type\t\tQtySold\t\tRevenue");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Standing Room Only\t{numStand}\t\t{valStand.ToString("c")}");
            Console.WriteLine($"Upper Bowl\t\t{numUpper}\t\t{valUpper.ToString("c")}");
            Console.WriteLine($"Lower Bowl\t\t{numLower}\t\t{valLower.ToString("c")}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Totals\t\t\t{numTotal}\t\t{valTotal.ToString("c")}");

            Console.ReadLine();
        }
    }
}
