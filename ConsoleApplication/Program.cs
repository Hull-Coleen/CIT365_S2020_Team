using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Coleen Hull";
            string location = "Sterling Va";
            string date = DateTime.UtcNow.ToString("d");
            DateTime Christmas = new DateTime(2020, 12, 25);
            double daysUntilChristmas = Christmas.Subtract(DateTime.Today).TotalDays;
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I live in {location}.");
            Console.WriteLine("The date is {0}", date);
            Console.WriteLine($"There are {daysUntilChristmas}  days until Christmas");
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I live in " + location);
            Console.WriteLine("The date is {0}", date);
            Console.WriteLine("There are " + daysUntilChristmas +
                " days until Christmas");


        }
    }
}
