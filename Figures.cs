using System;

namespace LibraryFigures
{
    
    public interface IFigure
    {   
        float FindArea();
    }

    public class Circle:IFigure
    {
        float _rad;
        const float pi = 3.14f;
 
        public Circle(float rad)
        {
            _rad = rad;
        }
        
        public float FindArea()
        { 
            return _rad*_rad*pi;
        }
    }

    public class Triangle:IFigure
    {
        float _sideA;
        float _sideB;
        float _sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool CheckTriangle()
        {
            bool check1 = Math.Pow(_sideA, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2);
            bool check2 = Math.Pow(_sideB, 2) == Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2);
            bool check3 = (Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2));

            return check1 || check2 || check3;
        }

        public float FindArea()
        {
            float halfMeter = (_sideA + _sideB + _sideC) / 2;
            return (float)Math.Sqrt(halfMeter*(halfMeter - _sideA)*(halfMeter - _sideB)*(halfMeter - _sideC));
        }

    }

    public static class IsRectangular
    {
        public static bool Triangle(this IFigure figure)
        {
            if (figure is Triangle triangle)
            {
                return triangle.CheckTriangle();
            }

            return false;
        }

    }


}
