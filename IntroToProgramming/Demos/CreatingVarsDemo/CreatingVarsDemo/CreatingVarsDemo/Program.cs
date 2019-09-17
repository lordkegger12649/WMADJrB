/*
 Alex Richard
 2019-09-13
 WMADJrB
 Variable Demo
 */

using System;

namespace CreatingVarsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alex";
            int age = 21;
            double height = 164.5;
            decimal hourlyRate = 11.50m;
            bool isActive = true;

            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Hourly Rate: " + hourlyRate);
            Console.WriteLine("Active: " + isActive);


            Console.ReadLine();
        }
    }
}
