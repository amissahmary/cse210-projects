using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you handled it.",
        "What made you smile today?",
        "What is one goal you want to achieve this week?",
        "Write about a person who inspires you and why.",
        "What lesson did you learn recently?",
        "If you could relive one moment from today, what would it be?",
        "What are three things you love about yourself?"
    };

    public string GetRandomPrompt()
    {
        //code goes here
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt =  _prompts[index];
        return prompt;
    }
}