using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MyJournal Program!");
        Console.WriteLine("Select one of the options presented below:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal ");
        Console.WriteLine("4. Save journal");
        string user_input = Console.ReadLine();
        int user_choice = int.Parse(user_input);

        if (user_choice == 1)
        {
            
        }

        else if (user_choice == 2)
        {

        }

        else if (user_choice == 3)
        {

        }

        else if (user_choice == 4)
        {
            Console.WriteLine("Enter the name of your file to save the journal:");
            string user_filename = Console.ReadLine();



        }

        else
        {

        }
    }
}