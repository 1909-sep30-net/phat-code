namespace ShapesApp.Library
{
    public interface IShape
    {
        int dimensions {get;}
        int Sides {get;}
        double perimeter();
    }
}

