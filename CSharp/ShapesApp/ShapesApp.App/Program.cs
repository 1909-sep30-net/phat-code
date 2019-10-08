using System;
using ShapesApp.Library;
namespace ShapesApp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rectangle 
            {
                Width = 3,
                Length = 4
            };
      
            var blck = new BlackCircle {radius = 2};

            Console.WriteLine(rec.perimeter()+" " + rec.Sides);

            Console.WriteLine(blck.perimeter()+" "+ blck.dimensions);
        }
    }
}
