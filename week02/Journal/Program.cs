using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        int choice = 0;

        Journal journal1 = new Journal();

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

             if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
                continue;
            }

            switch(choice)
            {
                case 1:
                    PromptGenerator prompt = new PromptGenerator();
                    Console.WriteLine($"Prompt: {prompt.GetRandomPrompt()}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();

                    Entry entry1 = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    entry1._date = theCurrentTime.ToShortDateString();
                    entry1._promptText = prompt.GetRandomPrompt();
                    entry1._entryText = response;
                    journal1.AddEntry(entry1);
                    break;

                case 2:
                    journal1.Display();
                    break;

                case 3:
                    Console.Write("Enter the name of the file: ");
                    journal1._filename = Console.ReadLine();
                    journal1.LoadFromFile(journal1._filename);
                    break;

                case 4:
                    Console.Write("Enter the name of the file: ");
                    journal1._filename = Console.ReadLine();
                    journal1.SaveToFile(journal1._filename);
                    break;

                case 5:
                    Console.WriteLine("Thank you for using our app.\n See you tomorrow.");
                    break;

                default:
                    Console.WriteLine("Enter a correct option from the menu.");
                    break;
            }
        }


        Console.WriteLine("Thank you!!");
    }
}