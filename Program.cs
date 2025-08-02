using GradeCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade (0 - 100): ");
        string input = Console.ReadLine() ?? string.Empty;

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
}
