using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int squared_number = SquareNumber(user_number);
        DisplayResult(user_name, squared_number);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("State your name:");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("State your favorite number:");
        string user_number_input = Console.ReadLine();
        int user_number = int.Parse(user_number_input);

        return user_number;

    }

    static int SquareNumber(int user_number)
    {
        int squared_number = user_number * user_number;
        return squared_number;
    }
    static void DisplayResult(string user_name, int squared_number)
    {
        Console.WriteLine($"{user_name}, your favorite number has been squared. Your squared number is {squared_number}.");
    }
}
