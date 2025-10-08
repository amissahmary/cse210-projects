/*
Exceeding Requirements
I added a method to the GoalManager class that displays the progress of the player.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🌟 Welcome to the Eternal Quest Program! 🌟");

        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
             Console.WriteLine("7. Show Progress Summary");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoalDetails(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.DisplayPlayerInfo(); break;
                case "5": manager.SaveGoals(); break;
                case "6": manager.LoadGoals(); break;
                case "7": manager.DisplayProgressSummary(); break;
                case "8": running = false; break;
                default: Console.WriteLine("Invalid option, try again."); break;
            }
        }

        Console.WriteLine("👋 Goodbye, and keep chasing your goals!");
    }
}
