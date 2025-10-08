using System;

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // speed = (distance / minutes) * 60
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        // pace = minutes / distance
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min) - " +
               $"Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}
