using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Welcome to the Journal Keep!");
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What do you want to do today?");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        Console.WriteLine("Thank you!!1");
    }
}