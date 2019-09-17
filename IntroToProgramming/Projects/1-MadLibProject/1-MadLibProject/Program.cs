using System;

namespace _1_MadLibProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The president passed his physical {noun} with flying
             * {pluralNoun1} this morning. Doctors gave him a {adjective1}
             * bill of health, but advised him to {verb} at least twenty
             * minutes a day and to eat less {adjective2} food.
             * At the {place} zoo, a five-hundred pound {animal} reached
             * out and grabbed a woman's {adjective3} camera right out of her
             * {bodyPart} when she tried to take his picture eating a {typeOfFood}.
             * The {animal} then {pastTenseVerb} the camera.
             * Sometimes it doesn't pay to diet. Popular comedian
             * {maleName}, who's lost more than {number} pounds,
             * was virtually caught with his {pluralNoun2} down when his
             * pants fell to the floor as he performed in front of an audience of five
             * hundred enthusiastic {pluralNoun3}.
             */

            //Declare Strings
            string noun, pluralNoun1, adjective1, verb, adjective2, place, animal, adjective3, bodyPart, food, pastTenseVerb, maleName, number, pluralNoun2, pluralNoun3;

            //Intro
            Console.WriteLine("************************************************");
            Console.WriteLine("Please help me create a unique News Story by providing the information that I request.\r\n");
            Console.WriteLine();
            
            //User Input
            //Adjective 1
            Console.Write("Enter an adjective: ");
            adjective1 = Console.ReadLine();

            Console.WriteLine("\r\nThanks! Great start.\r\n");

            //Adjective 2
            Console.Write("Enter another adjective: ");
            adjective2 = Console.ReadLine();

            //Adjective 3
            Console.Write("One more adjective please: ");
            adjective3 = Console.ReadLine();

            Console.WriteLine("\r\nGreat, we are doen with adjectives!\r\n");

            //Animal
            Console.Write("Enter an Animal: ");
            animal = Console.ReadLine();

            //Male Name
            Console.Write("Enter a male name of a person: ");
            maleName = Console.ReadLine();

            //Noun
            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            //Number
            Console.Write("Enter a number: ");
            number = Console.ReadLine();

            //Body Part
            Console.Write("Enter a part of the body: ");
            bodyPart = Console.ReadLine();

            //Past Tense Verb
            Console.Write("Enter a verb in past tense: ");
            pastTenseVerb = Console.ReadLine();

            //Place
            Console.Write("Enter a place: ");
            place = Console.ReadLine();

            Console.WriteLine("\r\nKeep it up...almost done!\r\n");

            //Plural Noun 1
            Console.Write("Enter a plural noun: ");
            pluralNoun1 = Console.ReadLine();

            //Plural Noun 2
            Console.Write("Enter another plural noun: ");
            pluralNoun2 = Console.ReadLine();

            //Plural Noun 3 (Unused)
            Console.Write("And another plural noun");
            Console.ReadLine();

            //Plural Noun 4
            Console.Write("One more plural noun: ");
            pluralNoun3 = Console.ReadLine();

            //Food
            Console.Write("Enter a type of food: ");
            food = Console.ReadLine();

            Console.WriteLine("\r\nYum...I'm hungry!\r\n");

            //Verb
            Console.Write("And finally, enter a Verb: ");
            verb = Console.ReadLine();

            //Results Info
            Console.WriteLine("\r\nOk, are you ready for the news story? Press enter to see it.\r\n");
            Console.ReadLine();
            Console.WriteLine("************************************************");
            Console.WriteLine("NEWS BREAK");
            Console.WriteLine("************************************************");
            //Results
            Console.WriteLine("\r\n" +
                $"The president passed his physical {noun} with flying " +
                $"{pluralNoun1} this morning. Doctors gave him a {adjective1} " +
                $"bill of health, but advised him to {verb} at least twenty " +
                $"minutes a day and to eat less {adjective2} food.\r\n\r\n" +
                $"At the {place} zoo, a five-hundred pound {animal} reached " +
                $"out and grabbed a woman\'s {adjective3} camera right out of her " +
                $"{bodyPart} when she tried to take his picture eating a {food}. " +
                $"The {animal} then {pastTenseVerb} the camera.\r\n\r\n" +
                $"Sometimes it doesn\'t pay to diet. Popular comedian " +
                $"{maleName}, who\'s lost more than {number} pounds, " +
                $"was virtually caught with his {pluralNoun2} down when his " +
                $"pants fell to the floor as he performed in front of an audience of five " +
                $"hundred enthusiastic {pluralNoun3}.\r\n\r\n");

            //Outro
            Console.WriteLine("Thanks for playing! Press enter to exit.");

            //Close on user input
            Console.ReadLine();
        }
    }
}
