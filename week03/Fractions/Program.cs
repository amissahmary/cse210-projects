using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fract1 = new Fraction();
        Fraction fract2 = new Fraction(5);
        Fraction fract3 = new Fraction(3,4);
        Fraction fract4 = new Fraction();
        fract4.SetTop(1);
        fract4.SetBottom(3);

        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
    }
}