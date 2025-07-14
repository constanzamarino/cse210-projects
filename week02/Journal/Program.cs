using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        

        Journal journal = new Journal();

        int user_choice = 0;


        while (user_choice != 5)
        {
            Console.WriteLine("Welcome to MyJournal Program!");
            Console.WriteLine("Select one of the options presented below:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal ");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Enter your choice:");

            string user_input = Console.ReadLine();

            if (!int.TryParse(user_input, out user_choice))
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                continue;
            }

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

            else if (user_choice == 5)
            {
                Console.WriteLine("Closing MyJournal...");
            }

            else
            {
                Console.WriteLine("Invalid option. Please select (1-5).");
            }

    }   }
}