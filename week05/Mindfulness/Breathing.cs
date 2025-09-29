using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){}

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(base.GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("\n");

            Console.Write("Now breathe out...");
            ShowCountDown(3);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}