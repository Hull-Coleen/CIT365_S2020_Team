using System;

namespace ConsoleApplication
{
    class Program
    {
        static void area()
        {
            double height, width;
            Console.WriteLine("What is the height of the window?");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the window?");
            width = double.Parse(Console.ReadLine());
            double totalWoodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);
            Console.WriteLine($"The length of the wood needed is {totalWoodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

        }
        static void Main(string[] args)
        {
            string name = "Coleen Hull";
            string location = "Sterling Va";
            string date = DateTime.UtcNow.ToString("d");
            DateTime Christmas = new DateTime(2020, 12, 25);
            double daysUntilChristmas = Christmas.Subtract(DateTime.Today).TotalDays;
            Console.WriteLine($"\t My name is {name}.");
            Console.WriteLine($"I live in {location}.");
            Console.WriteLine("The date is {0}", date);
            Console.WriteLine($"There are {daysUntilChristmas}  days until Christmas");
            area();
            Console.ReadKey();
        }
    }
}
