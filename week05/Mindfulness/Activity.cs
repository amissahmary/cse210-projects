using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
     }

     public int GetDuration(){
        return _duration;
     }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description} \n");
        Console.Write("How long, in seconds, would you like your session?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
       List<string> spinner = new List<string>() { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }


}