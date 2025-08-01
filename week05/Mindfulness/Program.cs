using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Presenting the project in: ");

        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(900);
        }

        Console.WriteLine("BOOOOOOOM");
        Thread.Sleep(700);
        Console.WriteLine("Welcome to the Mindfulness Program");
    }
}

    

    



