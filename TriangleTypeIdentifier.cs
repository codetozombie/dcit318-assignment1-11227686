using System;

namespace AssignmentApp
{
    public static class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== Triangle Type Identifier ===");
            int[] sides = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sides[i] = GetValidSide(i + 1);
            }

            if (!IsValidTriangle(sides))
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
            else
            {
                string type = GetTriangleType(sides);
                Console.WriteLine($"Triangle Type: {type}");
            }
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }

        private static int GetValidSide(int sideNumber)
        {
            int side;
            while (true)
            {
                Console.Write($"Enter side {sideNumber}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out side) && side > 0)
                    return side;
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        private static bool IsValidTriangle(int[] sides)
        {
            Array.Sort(sides);
            return sides[0] + sides[1] > sides[2];
        }

        private static string GetTriangleType(int[] sides)
        {
            if (sides[0] == sides[1] && sides[1] == sides[2])
                return "Equilateral";
            if (sides[0] == sides[1] || sides[1] == sides[2] || sides[0] == sides[2])
                return "Isosceles";
            return "Scalene";
        }
    }
}