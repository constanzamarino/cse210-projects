using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the magic number in here --> ");
        int userMagic_number = int.Parse(Console.ReadLine());

        Console.WriteLine("Type your guess right here --> ");
        int user_guess = int.Parse(Console.ReadLine());

        while (user_guess != userMagic_number)
        {

            if (user_guess > userMagic_number)
            {
                Console.WriteLine("Guess lower!");
            }
            else if (user_guess < userMagic_number)
            {
                Console.WriteLine("Guess higher!");
            }
            user_guess= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Congrats! You have guessed it!");


    }
}
    



        
