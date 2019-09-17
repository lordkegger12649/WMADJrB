using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, length, perimeter;

            Console.WriteLine("**********Perimeter Calculator**********\r\n");
            Console.WriteLine("This application will calculate Perimeter when given width and length.\r\n");
            Console.Write("What is the width? ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the length? ");
            length = Convert.ToDouble(Console.ReadLine());

            perimeter = (width * 2) + (2 * length);

            Console.WriteLine($"\r\nThe Perimeter is {perimeter}\r\n");
            Console.WriteLine("Press ENTER to Exit");

            Console.ReadLine();
        }
    }
}
