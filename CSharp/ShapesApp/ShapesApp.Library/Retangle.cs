namespace ShapesApp.Library
{
    public class Rectangle : IShape 
    {
        public double Width { get; set;}
        public double Length{get; set;}

        
        public int dimensions=>2; 
        public int Sides=>2;
        public double perimeter ()=> Width * Length;
    }
}