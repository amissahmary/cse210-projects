using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("You will have a few seconds to think...");
        ShowCountDown(5);

        Console.WriteLine("\nWhen you are ready, press Enter to start listing items!");
        Console.ReadLine();

        Console.WriteLine("Start listing items (press Enter after each item):");
        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        var entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string line = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(line))
            {
                entries.Add(line);
            }
        }

        return entries;
    }
}