using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assign = new Assignment("Bernice","Calculus");
        Console.WriteLine(assign.GetSummary());

        Console.WriteLine("\n");

        MathAssignment assigned = new MathAssignment("Frank", "Calculus", "7.3", "1-5");
        Console.WriteLine(assigned.GetSummary());
        Console.WriteLine(assigned.GetHomeworkList());

        WritingAssignment assigns = new WritingAssignment("Ochi", "Teenage Pregnancy", "Causes of Teenage Pregnancy");
        Console.WriteLine(assigns.GetSummary());
        Console.WriteLine(assigns.GetWritingInformation());
    }
}