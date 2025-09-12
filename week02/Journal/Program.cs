using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Keep!");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What do you want to do today?");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            switch(choice)
            {
                case 1:
                    PromptGenerator prompt = new PromptGenerator();
                    Console.WriteLine($"Prompt: {prompt.GetRandomPrompt()}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    Entry entry1 = new Entry();
                    entry1._date = " ";
                    entry1._promptText = prompt;
                    entry1._entryText = response;
                    Journal journal1 = new Journal();
                    journal1.AddEntry(entry1.Display());
                    break;

                case 2:
                    break;
            }
        }


        Console.WriteLine("Thank you!!");
    }
}