using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal taxAmount = 3.12m;
            const decimal taxRate = 500m;
            decimal propertyValue, taxOwed;
            Console.WriteLine("**********Property Tax Calculator**********\r\n");
            Console.WriteLine("Property tax is calculated as $3.12 for every $500 of the property's value.\r\n");

            Console.Write("What is your property value? ");
            propertyValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            taxOwed = taxAmount * (propertyValue / taxRate);
            Console.WriteLine($"You owe {taxOwed.ToString("c")} in property tax on your property valued at {propertyValue.ToString("c")}\r\n");
            Console.WriteLine("Press ENTER to Exit");

            Console.ReadLine();
        }
    }
}
