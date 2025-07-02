using System;

class Program
{
    static void Main(string[] args)
    {
        string Play_again = "YES";

        while (Play_again.ToUpper() == "YES")
        {
            Random Generate_Random_Number = new Random();
            int Random_number = Generate_Random_Number.Next(1, 101);
            int attempts = 1;

            Console.WriteLine("Guess the random number by typing in here --> ");
            int User_guess = int.Parse(Console.ReadLine());

            while (User_guess != Random_number)

            {
                if (User_guess > Random_number)
                {
                    Console.WriteLine("Guess lower!");
                }
                else if (User_guess < Random_number)
                {
                    Console.WriteLine("Guess higher!");
                }

                Console.WriteLine("Try again!");
                User_guess = int.Parse(Console.ReadLine());
                attempts++;
            }
            Console.WriteLine("Congratulations! You've guessed the magic number!");
            Console.WriteLine($"It took you {attempts} guesses.");

            Console.WriteLine("Do you want to keep playing? (YES/NO)");
            Play_again = Console.ReadLine();

        }

        Console.WriteLine("Thanks for playing! Hope to see you soon ;) ");

        
        

    }
}
    



        
