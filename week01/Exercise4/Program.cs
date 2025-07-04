using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Please, type as many numbers as seems right to you. Enter 0 when you are done.");
        int user_numbers = -1;

        while (user_numbers != 0)

        {
            Console.WriteLine("Type a number:");
            string user_input = Console.ReadLine();
            user_numbers = int.Parse(user_input);

            if (user_numbers != 0)
            {
                numbers.Add(user_numbers);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum of the list numbers is equal to = {sum}.");
        Console.WriteLine($"The average of the list numbers is equal to = {average}.");

        int max_number = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max_number)
            {
                max_number = number;
            }

        }

        Console.WriteLine($"The largest number is {max_number}.");

        int smallest_positive_number = numbers[0];
        foreach (int number in numbers)
        {
            if (number < smallest_positive_number && number > 0)
            {
                smallest_positive_number = number;
            }
        }

        Console.WriteLine($"The smallest positive number from the list is {smallest_positive_number}.");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        


    }
    
    
}  

