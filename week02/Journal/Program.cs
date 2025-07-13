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
        string user_input = Console.ReadLine();
        int user_choice = int.Parse(user_input);

        Journal journal = new Journal();

        while (user_choice != 5)

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
                Console.WriteLine("Enter the name of your file to save the journal:");
                string filename = Console.ReadLine();


            }

            else
            {
                Console.WriteLine("");
            }
    }
}