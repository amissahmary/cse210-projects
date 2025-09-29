using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;

        while(choice != 4){

            Console.Clear();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit.");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.Run();
                    break;

                case 2:
                    Reflection reflection = new Reflection();
                    reflection.Run();
                    break;

                case 3:
                    Listing listing = new Listing();
                    listing.Run();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
    }
}