namespace ShapesApp.Library 
{
    public abstract class Circle : IShape
    {
        public int dimensions => 0;
        public int Sides => 0;

        public abstract double perimeter();
    }
}