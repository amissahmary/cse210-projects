using System;

public class Circle : Shape{
    private double _radius;

    public Circle(double radius) : base("Pink"){
        _radius = radius;
    }

    public override double GetArea(){
        return 3.1423 * _radius * _radius;
    }
}