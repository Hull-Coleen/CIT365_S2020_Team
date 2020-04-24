using System;

namespace ConsoleApplication
{
    class Program
    {
        static void area()
        {
            // variables to holde user input
            double height, width;
            // gather user input
            Console.WriteLine("What is the height of the window in meters?");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the window in meters?");
            width = double.Parse(Console.ReadLine());
            // formulas to ge the area for two panes of glass and the length of
            // wood needed to frame the window
            double totalWoodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);
            //display the results to the user
            Console.WriteLine($"The length of the wood needed is {totalWoodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");

        }
        static void myInfo()
        {
            // variables 
            string name = "Coleen Hull";
            string location = "Virginia";
            // display variables
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I live in {location}.");
        }
        static void myInfo2()
        {
            // variables 
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("In what state do you live?");
            string location = Console.ReadLine();
            // display variables
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I live in {location}.");
        }
        static void date()
        {
            // today's date
            string date = DateTime.UtcNow.ToString("d");
            // Christmas
            DateTime Christmas = new DateTime(2020, 12, 25);
            // subtract today's date from Christmas date
            double daysUntilChristmas = Christmas.Subtract(DateTime.Today).TotalDays;
            // display the date and days to Christmas
            Console.WriteLine("The date is {0}", date);
            Console.WriteLine($"There are {daysUntilChristmas}  days until Christmas");

        }
        static void Main(string[] args)
        {
            myInfo();
            Console.WriteLine("\n");
            myInfo2();
            Console.WriteLine("\n");
            date();
            Console.WriteLine("\n");
            area();
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
