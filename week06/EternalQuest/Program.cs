using System;

class Program
{
    static void Main(string[] args)
    {
        ManageGoals goalManager = new ManageGoals();
        int user_choice = 0;

        Console.WriteLine("Welcome to the Eternal Quest Program!\n");

        while (user_choice != 6)
        {
            goalManager.DisplayPlayerData();

            Console.WriteLine("Menu:\n1.Add a new goal\n2.List a goal\n3.Save your goals\n4.Load your goals\n5.Record an event\n6.Quit\n");
            Console.Write("\nSelect an option from the menu:");
            user_choice = int.Parse(Console.ReadLine());

            if (user_choice == 1)
            {
                goalManager.AddGoal();
            }

            else if (user_choice == 2)
            {
                goalManager.ListGoals();
            }

            else if (user_choice == 3)
            {
                goalManager.SaveGoal();
            }

            else if (user_choice == 4)
            {
                goalManager.LoadGoal();
            }

            else if (user_choice == 5)
            {
                goalManager.RecordEvent();
            }

            else if (user_choice == 6)
            {
                Console.WriteLine("Thanks for using the Eternal Quest Program! Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}
        
        