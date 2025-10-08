using System;

public class Cycling : Activity
{
    private double _speed; 

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min) - " +
               $"Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}
