using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;
            const int convFact = 703;
            Console.WriteLine("**********BMI Calculator**********\r\n");
            Console.WriteLine("" +
                "This application will calculate Body Mass Index.\r\n" +
                "when the user supplies their weight in pounds and height in inches.\r\n");

            Console.Write("Please enter your weight in lbs: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            bmi = (weight * convFact) / (height * height);
            Console.WriteLine($"Your BMI is {bmi}\r\n");

            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();
        }
    }
}
