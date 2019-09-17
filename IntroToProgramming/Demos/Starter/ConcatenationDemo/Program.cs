using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1
            // using + operator to concatenate literals
            //string msg = "Hello, my name is Stephen.  I love to program in C#.  " +
                //"I am going to study really hard this term and learn as much about programming as possible.  " +
              //  "This will enable me to be successful and land a great job when I graduate!.";
            //Console.WriteLine(msg);

            string firstName = "Alex";
            string lastName = "Richard";
            string homeTown = "Moncton";
            string msg1 = "Hello, my name is " + firstName + " " + lastName + " and I am from " + homeTown + ".";
            //Console.WriteLine(msg1);
            string msg2 = string.Format("Hello, my name is {0} {1} and I am from {2}", firstName, lastName, homeTown);
            //Console.WriteLine(msg2);

            string msg3 = $"Hello, my name is {firstName} {lastName} and I am from {homeTown}.";
            Console.WriteLine(msg3);
            Console.ReadLine();
        }
    }
}
