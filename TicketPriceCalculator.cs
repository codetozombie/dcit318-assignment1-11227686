using System;

namespace AssignmentApp
{
    public static class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== Ticket Price Calculator ===");
            int age = GetValidAge();
            int price = (age >= 65 || age <= 12) ? 7 : 10;
            Console.WriteLine($"Age: {age} => Ticket Price: GHC{price}");
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }

        private static int GetValidAge()
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age >= 0)
                    return age;
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
            }
        }
    }
}