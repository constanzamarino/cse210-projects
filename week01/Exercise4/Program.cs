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
            Console.WriteLine("Enter a number:");
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

        Console.WriteLine($"The sum of the numbers in the list is equal to = {sum}.");
        Console.WriteLine($"The average of the numbers in the list is equal to = {average}.");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number from the list is {max}.");

        int smallest_number = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallest_number)
            {
                smallest_number = number;
            }

        }
        Console.WriteLine($"The smallest number from the list is {smallest_number}.");
}   }