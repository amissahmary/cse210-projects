/* 
Exceeding Requirements:
I added an option to allow the user to edit and delete previous entries.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        int choice = 0;

        Journal journal1 = new Journal();
        PromptGenerator prompt1 = new PromptGenerator();

        while (choice != 7)
        {
            Console.WriteLine("Welcome to the Journal Keep!\n");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Edit entry");
            Console.WriteLine("6. Delete entry");
            Console.WriteLine("7. Quit\n");

            Console.Write("What do you want to do today?");
            string input = Console.ReadLine();

             if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number between 1 and 5.\n");
                continue;
            }

            switch(choice)
            {
                case 1:
                    string prompt = prompt1.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();

                    Entry entry1 = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    entry1._date = theCurrentTime.ToShortDateString();
                    entry1._promptText = prompt;
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
                    journal1.Display();
                    Console.Write("Enter the entry number to edit: ");
                    string input1 = Console.ReadLine();
                    if(int.TryParse(input1, out int editIndex))
                    {
                        journal1._index = editIndex -1;
                        journal1.EditEntry(journal1._index);
                        journal1.SaveToFile(journal1._filename);
                    }
                    break;

                case 6:
                    journal1.Display();
                    Console.Write("Enter the entry number to delete: ");
                    string input2 = Console.ReadLine();
                    if(int.TryParse(input2, out int deleteIndex))
                    {
                        journal1._index = deleteIndex - 1;
                        journal1.DeleteEntry(journal1._index);
                        journal1.SaveToFile(journal1._filename);
                    }
                    break;

                 case 7:
                    Console.WriteLine("Thank you for using our app.\nSee you tomorrow.");
                    break;

                default:
                    Console.WriteLine("Enter a correct option from the menu.");
                    break;
            }
        }


        Console.WriteLine("Thank you!!");
    }
}