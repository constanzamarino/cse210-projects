using System;

class Program
{
    static void Main(string[] args)

    {
        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");

        Console.WriteLine("Welcome to the Scripture Memorizer program!");


        while (scripture.CompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Type 'enter' to continue. Type 'quit' after you are done.");
            string user_choice = Console.ReadLine();

            if (user_choice == "enter".ToLower())
            {
                
            }

            else if (user_choice == "quit".ToLower())
            {
                break;
            }

            scripture.HideRandomWords(2);
        }
        
    }
}