using System;

using GradeCalculator;
using TicketPriceCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.Write("Enter option (1 or 2): ");
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
        else
        {
            Console.WriteLine("Invalid choice. Exiting.");
        }
    }
}
