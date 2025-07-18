using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ScriptureMemorizer program!");
        Console.WriteLine("Type 'enter' to continue. Type 'quit' after you are done.");
        string user_choice = Console.ReadLine();



        while (user_choice != "quit".ToLower())
        {
            if (user_choice == "enter")
            {
                
            }

            else if (user_choice == "quit")
            {
                Console.WriteLine();
            }
        }
    }
}