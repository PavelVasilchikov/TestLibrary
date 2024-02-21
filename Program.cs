using LibraryFigures;
using System;

namespace Test
{ 
    class Program
    {
        static void Main()
        {
            float radius = 2.4f;

            float Aside = 6.0f;
            float Bside = 8.4f;
            float Cside = 10.2f;

            IFigure circle = new Circle(radius);
            IFigure triangle = new Triangle(Aside, Bside, Cside);

            Console.WriteLine(circle.FindArea());
            Console.WriteLine(triangle.FindArea());
            Console.WriteLine($"The triangle is rectangular - {IsRectangular.Triangle(triangle)}");
            
        }
    }
}
