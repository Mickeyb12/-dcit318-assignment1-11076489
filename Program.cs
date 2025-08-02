using System;

using GradeCalculator;
using TicketPriceCalculator;
using TriangleTypeIdentifier;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.Write("Enter option (1, 2 or 3): ");
        string choice = Console.ReadLine()!;

        if (choice == "1")
        {
            Console.WriteLine("Enter your grade (0 - 100): ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
            {
                GradeCalculator.GradeCalculator calculator = new GradeCalculator.GradeCalculator();
                string letter = calculator.GetLetterGrade(grade);
                Console.WriteLine($"Your grade is: {letter}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int age) && age > 0)
            {
                TicketPriceCalculator.TicketPriceCalculator ticketCalculator = new TicketPriceCalculator.TicketPriceCalculator();
                decimal price = ticketCalculator.GetTicketPrice(age);
                Console.WriteLine($"Your ticket price is: GH₵{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
        else if (choice == "3")
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            Console.Write("Side 1: ");
            string side1Input = Console.ReadLine()!;
            Console.Write("Side 2: ");
            string side2Input = Console.ReadLine()!;
            Console.Write("Side 3: ");
            string side3Input = Console.ReadLine()!;

            if (double.TryParse(side1Input, out double side1) &&
                double.TryParse(side2Input, out double side2) &&
                double.TryParse(side3Input, out double side3))
            {
                TriangleTypeIdentifier.TriangleTypeIdentifier triangleIdentifier = new TriangleTypeIdentifier.TriangleTypeIdentifier();
                string triangleType = triangleIdentifier.IdentifyTriangleType(side1, side2, side3);
                Console.WriteLine($"The triangle type is: {triangleType}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for the sides.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting.");
        }
    }
}

