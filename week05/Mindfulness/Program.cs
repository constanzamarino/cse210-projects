// I added an option to save the Reflection and Listing activities. These saving methods are not in the Activity class
// because Breathing doesn't have it, since there's no information to save. I added also the date of each activity the user does.

using System;
using System.Threading.Channels;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        int user_choice = 0;

        while (user_choice != 5)

        {
            Breathing breathingActivity = new Breathing("", "", 0);
            Reflection reflectionActivity = new Reflection("", "", 0);
            Listing listingActivity = new Listing("", "", 0, 0);
            

            Console.WriteLine("Menu:");
            Console.WriteLine("\n1.Breathing Activity\n2.Reflection Activity\n3.Listing Activity\n4.Save Reflection and Listing activities\n5.Quit\n");
            Console.WriteLine("Please, select an option from the menu by entering its corresponding number:");

            string user_input = Console.ReadLine();
            if (int.TryParse(user_input, out user_choice))
            {
                Console.WriteLine("Invalid input. Please, select an option from the menu by entering its corresponding number: ");
            }

            if (user_choice == 1)
            {
                breathingActivity.RunBreathingActivity();
                breathingActivity.GetActivityDate();

            }

            else if (user_choice == 2)
            {
                reflectionActivity.RunReflectionActivity();
                reflectionActivity.DisplayActivityDate();
                

            }

            else if (user_choice == 3)
            {
                listingActivity.RunListingActivity();
                listingActivity.DisplayActivityDate();
                
                
            }

            else if (user_choice == 4)
            {
                reflectionActivity.SaveReflectionActivity();
                listingActivity.SaveListingActivity();
            }

            else
            {
                Console.WriteLine("Invalid number. Please, select an option from the menu by entering its corresponding number (1-4): ");
            }


        }
       
    }
}

    

    



