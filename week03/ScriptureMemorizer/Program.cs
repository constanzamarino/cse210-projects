using System;

class Program
{
    static void Main(string[] args)

    {
        RandomScriptureGenerator generator = new RandomScriptureGenerator();
        Scripture scripture = generator.GetRandomScripture();
        Reference reference = scripture._reference;
        
        Console.WriteLine("Welcome to the Scripture Memorizer program!");
        


        while (!scripture.CompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nType 'enter' to continue. Type 'quit' after you are done.");
            string user_choice = Console.ReadLine().ToLower();


            if (user_choice == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
        
    }
}