using System;
/*
 Alex Richard
 2019-09-16
 WMADJrB
 Type Conversion Demo
 */

namespace TypeConversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Does NOT Work
            //int = "blah blah";

            /* Implicit Conversions
             * can be made when the value to be stored can fit
             * into the variable without being truncated or rounded off */

            //Does Work
            //int myInt = 1234567;
            //long myIntLong = myInt;

            //Does NOT Work
            //long myLong = 1234567;
            //int myLongIntWrong = myLong;

            //Explicit Conversion CASTING
            //long myLong = 1234567;
            //int myLongIntCorrect = (int)myLong;
            //Console.WriteLine(myLongIntCorrect);

            //double myDouble = 123.45;
            //int myDoubleInt = (int)myDouble;
            //Console.WriteLine(myDoubleInt);

            //Does NOT Work
            //string myString = "1234567";
            //int myStringIntCast = (int)myString;

            //Does Work
            //string myStringCorrect = "1234567";
            //int myIntStringCorrect = Convert.ToInt32(myStringCorrect);

            //Does NOT Work
            //string myStringDecimalInt = "123.45";
            //int myIntStringDecimalInt = Convert.ToInt32(myStringDecimal);

            //Does Work
            //string myDoubleString = "123.45";
            //double myStringDouble = Convert.ToDouble(myDoubleString);

            Console.ReadLine();
        }
    }
}
