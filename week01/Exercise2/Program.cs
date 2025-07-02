using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("What is your grade percentage? ");
        string user_percentage = Console.ReadLine();
        int percentage = int.Parse(user_percentage);

        string letter_grade = "";


        if (percentage >= 90)
        {
            letter_grade = "A";
        }

        else if (percentage >= 80)
        {
            letter_grade = "B";
        }

        else if (percentage >= 70)
        {
            letter_grade = "C";
        }

        else if (percentage >= 60)
        {
            letter_grade = "D";

        }

        else
        {
            letter_grade = "F";
        }

        int last_digit = percentage % 10;
        string sign = "";

        if (letter_grade != "F")
        
        if (last_digit >= 7)
            {
                sign = "+";

                if (letter_grade == "A" && last_digit >= 7)
                {
                    sign = "";
                }

            }

            else if (last_digit < 3)
            {
                sign = "-";
            }

            else
            {
                sign = "";
            }

        Console.WriteLine($"Your final grade is {letter_grade}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed this course!");
        }

        else
        {
            Console.WriteLine("You haven't passed. Good luck for the next time, you can do it!");
        }

        







    }  
    
   
}