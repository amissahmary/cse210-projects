using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guesses;

        int num = 0;

        do
        {
             num += 1;

            Console.Write("Guess a number: ");

            string input1 = Console.ReadLine();

            int guess = int.Parse(input1);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            guesses = guess;
        } while (magic != guesses);

        Console.WriteLine($"You had the answer on the {num}th trial.");
    }
}