using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ScriptureMemorizer program!");
        Console.WriteLine("Press enter to continue. Type 'quit' as per your preference or after you are done. ");
        string user_choice = Console.ReadLine();



        while (user_choice != "quit".ToLower())
        {
            if (user_choice == "")
            {

            }

            else if (user_choice == "quit")
            {
                Console.WriteLine();
            }
        }
    }
}