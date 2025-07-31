using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Elizabeth Rodriguez", "Integrals");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Theodore Fisher", "4.3", "10-15", "Limits & Derivatives");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Fernando Gonzalez", "Argentinian History", "Military Dictatorship consequences: National Reorganization Process");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}
