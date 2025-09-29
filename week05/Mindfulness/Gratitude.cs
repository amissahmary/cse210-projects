using System;
using System.Collections.Generic;

public class Gratitude : Activity
{
    private List<string> _prompts = new List<string>() {
        "What are three things you are grateful for today?",
        "Name a person who had a positive impact on your life recently.",
        "Think about a small moment this week that brought you joy."
    };

    private Random _random = new Random();

    public Gratitude() : base("Gratitude", "This activity helps you reflect on things you are thankful for.") { }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---\n");

        Console.WriteLine("You will have a few seconds to think...");
        ShowCountDown(5);

        Console.WriteLine("\nStart writing your thoughts (press Enter after each, leave empty and press Enter to finish):");

        List<string> entries = new List<string>();
        while (true)
        {
            Console.Write("> ");
            string line = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(line)) break;
            entries.Add(line);
        }

        Console.WriteLine($"\nYou listed {entries.Count} things you are grateful for!");
        DisplayEndingMessage();
    }
}
