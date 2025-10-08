using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercise Tracking Program (Metric System) ===\n");

        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2022", 30, 4.8);   
        Cycling cycle = new Cycling("04 Nov 2022", 45, 25.0); 
        Swimming swim = new Swimming("05 Nov 2022", 25, 40);  

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
