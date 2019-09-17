/*
 Alex Richard
 2019-09-16
 WMADJrB
 Getting User Input Demo
 */
using System;

namespace GettingUserInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your name: "); //Asks for user input
            string name = Console.ReadLine(); //Waits for user input and sets string firstName
            switch (name) {
                case "age":
                    goto Age;
            }
            Console.Write("Whats your street adress: "); //Asks for street address
            string address = Console.ReadLine(); //Waits for user input and sets string address
            Console.Write("What city do you live in: "); //Asks for city of residence
            string city = Console.ReadLine(); //Waits for user input and set string city
            
            Console.WriteLine($"Hello {name} from {address} in {city}!"); //Prints Response

            Age:
            Console.Write("What's your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You're {age} years old!");

            Console.ReadLine(); //Waits for user input
        }
    }
}
