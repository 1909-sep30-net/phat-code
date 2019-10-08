using System;

namespace ShapesApp.Library
{
    public class BlackCircle : Circle
    {
        public double radius {get;set;}
        public override double perimeter() => 2 * Math.PI * radius;


    }
}