//Alex Richard
//WMADJrB
//09-09-2019
//Exercise One

using System;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Concatenation 1
            string name = "Fred";
            string msg = name + " was excited about starting his course at NBCC.\r\n" + 
                "Web and Mobile Application development was the program Fred entered in the Fall of 2019\r\n" +
                "Intro to Programming is going to be the course " + name + " likes best. " + name + " is going to study very hard.\r\n" +
                "Each night " + name + " is going to spend time reviewing all of the course material.\r\n" +
                name + " will be committed to learning as much as possible about C# in 2019!";
            Console.WriteLine(msg);
            Console.WriteLine("\r\n");
            //String Concatenation 2
            string msg2 = string.Format("{0} was excited about starting his course at NBCC.\r\n" +
                "Web and Mobile Application devlopment was the program {0} entered in the Fall of 2019\r\n" +
                "Intro to Programming is going to be the course {0} likes best. {0} is going to study very hard.\r\n" +
                "Each night {0} is going to spend time reviewing all of the course material.\r\n" +
                "{0} will be commited to learning as much as possible about C# in 2019!", name);
            Console.WriteLine(msg2);
            Console.WriteLine("\r\n");
            //String Concatenation 3
            string msg3 = $"{name} was excited about starting his course at NBCC.\r\n" +
                $"Web and Mobile Application devlopment was the program {name} entered in the Fall of 2019\r\n" +
                $"Intro to Programming is going to be the course {name} likes best. {name} is going to study very hard.\r\n" +
                $"Each night {name} is going to spend time reviewing all of the course material.\r\n" +
                $"{name} will be commited to learning as much as possible about C# in 2019!";
            Console.WriteLine(msg3);
            Console.ReadLine();
        }
    }
}
