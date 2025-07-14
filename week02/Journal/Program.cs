using System;
using System.IO;
using System.Collections.Generic;


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
        Console.WriteLine("5. Quit");
       
        Journal journal = new Journal();
        int user_choice = 0;

        while (user_choice != 5)

         Console.WriteLine("Enter your choice:");
         string user_input = Console.ReadLine();
         user_choice = int.Parse(user_input);

        if (user_choice == 1)
        {
            journal.AddEntry();
        }

        else if (user_choice == 2)
        {
            journal.DisplayJournal();
        }

        else if (user_choice == 3)
        {
            journal.LoadFromFile();
        }

        else if (user_choice == 4)
        {
            journal.SaveToFile();

        }

        else
        {
            Console.WriteLine("I don't understand that answer.");
        }
    }
}