/*
 Alex Richard
 2019-09-13
 WMADJrB
 Exersize Two
 */
using System;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John", lastName = "Smith", company = "Joe Smith Plumbing", streetAddress = "123 Main Road", city = "Moncton",
                phone = "+1 (555) 555-1234", orderCategory = "Tools", productName = "Expansion Wrench 3000";

            bool isManager = true, onSale = false;

            int numYearsAtCompany = 25, orderNum = 14224, productNum = 1556, quantity = 1;

            double heightInInches = 84.4;

            decimal salary = 25.55m, discount = 14.25m, itemPrice = 225.35m;

            Console.WriteLine($"Employee Name: {firstName} {lastName}\r\n" +
                $"Company: {company}\r\n" +
                $"Company Address: {streetAddress}, {city}\r\n" +
                $"Company Phone Number: {phone}\r\n" +
                $"Employee Experience: {numYearsAtCompany} Years\r\n" +
                $"Employee Height: {heightInInches}\"\r\n" +
                $"Employee salary: ${salary}\r\n" +
                $"Is Employee a Manager: {isManager}\r\n" +
                $"Order #: {orderNum}\r\n" +
                $"Product #: {productNum}\r\n" +
                $"Category: {orderCategory}\r\n" +
                $"Product Name: {productName}\r\n" +
                $"Quantity: {quantity}\r\n" +
                $"On Sale: {onSale}\r\n" +
                $"Discount: {discount}%\r\n" +
                $"Price: ${itemPrice}");

            Console.ReadLine();
        }
    }
}
