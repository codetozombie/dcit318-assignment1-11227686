using System;

namespace AssignmentApp
{
    public static class GradeCalculator
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("=== Grade Calculator ===");
            int grade = GetValidGrade();
            string letter = GetLetterGrade(grade);
            Console.WriteLine($"Numerical Grade: {grade} => Letter Grade: {letter}");
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }

        private static int GetValidGrade()
        {
            int grade;
            while (true)
            {
                Console.Write("Enter a grade (0-100): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                    return grade;
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        private static string GetLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}