using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade?: ");

        string input = Console.ReadLine();

        int grade = int.Parse(input);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You had grade {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class. Try again next time.");
        }
    }
}