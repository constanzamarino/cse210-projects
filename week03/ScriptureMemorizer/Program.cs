// I added a new class called RandomScriptureGenerator that includes a constructor that includes 9 different scriptures in a list and a getter method so the program chooses a random scripture.
// I also added the option to change the scripture if that's what the user wants.

using System;

class Program
{
    static void Main(string[] args)

    {
        RandomScriptureGenerator generator = new RandomScriptureGenerator();
        Scripture scripture = generator.GetRandomScripture();
        Reference reference = scripture._reference;


        while (!scripture.CompletelyHidden())
        {
            Console.WriteLine("Welcome to the Bible Scripture Memorizer Program! Try to memorize the scripture following the instructions below:");
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nType 'enter' to hide random words as much as you prefer. Type 'quit' after you are done. If you want to change the scripture, type 'change' ");
            string user_choice = Console.ReadLine().ToLower();

            if (user_choice == "change")
            {
                scripture = generator.GetRandomScripture();
                reference = scripture._reference;

                Console.WriteLine("\nScripture changed successfully!");
                Console.Clear();
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nType 'enter' to hide random words as much as you prefer. Type 'quit' after you are done. If you want to change the scripture, type 'change' ");

                Console.ReadLine().ToLower();
            }

            else if (user_choice == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
        
    }
}