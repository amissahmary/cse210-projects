using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
     {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    private Random _random = new Random();

    public Reflection() : base("Reflections", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){}

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(base.GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {
        
    }
}