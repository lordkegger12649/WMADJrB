using System;
/*
    Alex Richard
    2019-09-16
    WMADJrB
    Getting User Input Exercise
*/

namespace GettingUserInputExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("********************************************");
            Console.WriteLine("Hello Please Answer The Following Questions.");
            Console.WriteLine("Press Enter Key To Start!");
            Console.WriteLine("********************************************");
            Console.ReadLine();
            
            //Name
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            
            //Thank you, few more questions
            Console.WriteLine($"Thank You {lastName}, {firstName}. Only A Few More Questions");
            Console.WriteLine("Press Enter Key To Continue");
            Console.ReadLine();
            Console.WriteLine();

            //Age
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Home Town and Current Residence
            Console.Write("What city were you born in? ");
            string homeCity = Console.ReadLine();
            Console.Write("What city do you live in now? ");
            string currentCity = Console.ReadLine();

            //Mariatal Status
            Console.Write("Are your married (true/false)? ");
            bool married = Convert.ToBoolean(Console.ReadLine());

            //First Job
            Console.Write("At which company was your first job? ");
            string firstCompany = Console.ReadLine();
            Console.Write("What was the hourly wage of your first job? ");
            decimal wage = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            //Info Out
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.WriteLine($"You are {age} years old and were born in {homeCity} and curently live in {currentCity}.");
            Console.WriteLine($"Your first job was at {firstCompany} making {wage.ToString("C")}/hour");
            Console.WriteLine($"I Asked if you were married and you said {married}.");
            Console.WriteLine();
            Console.WriteLine("********************************************");

            //Thank You Quit
            Console.WriteLine($"Thanks for answering my questions, {firstName} {lastName}.");
            Console.WriteLine("Press Enter Key To Quit");
            Console.ReadLine();
        }
    }
}
