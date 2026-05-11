using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display the opening welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // 3. Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // 4. Check if the sum of dimensions exceeds the limit
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            // 5. Calculate the quote
            // Formula: (Width * Height * Length * Weight) / 100
            float dimensionsProduct = width * height * length;
            float quote = (dimensionsProduct * weight) / 100;

            // 6. Display the final quote formatted as a dollar amount
            // The "C" format specifier formats the number as local currency
            Console.WriteLine($"Your estimated total for shipping this package is: {quote:C}");
            Console.WriteLine("Thank you!");
            
            // Keep console window open for the user to see the result
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
