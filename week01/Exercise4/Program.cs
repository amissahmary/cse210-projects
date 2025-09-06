using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when you are done.");

        int items = 0;

        do
        {
            Console.Write("Enter number: ");

            string input = Console.ReadLine();

            int item = int.Parse(input);

            if (item == 0)
            {
                break;
            }

            else
            {
               numbers.Add(item);  
            }

            items = item;
        } while (items != 0);

        int sum = 0;

        int max = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"The sum is : {sum}");

        double average =  (double) sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}