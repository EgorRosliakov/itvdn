
using Task_4.dto;

namespace Task_4.models
{
    public class Figure
    {
        private Point[] _points;
        public string Name { get;}

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree)
        {
            _points = new[] {sidesOne, sidesTwo, sidesThree};
            Name = "triangle";
        }

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree, Point sidesFour)
            : this(sidesOne, sidesTwo, sidesThree)
        {
            _points = new[] { sidesOne, sidesTwo, sidesThree, sidesFour };
            Name = "quadrilateral";
        }

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree, Point sidesFour, Point sidesFive)
            : this(sidesOne, sidesTwo, sidesThree, sidesFour)
        {
            _points = new[] { sidesOne, sidesTwo, sidesThree, sidesFour, sidesFive };
            Name = "pentagon";
        }

        private double LengthSide(Point A, Point B) 
            => Math.Sqrt(Math.Pow(B.NumberX - A.NumberX, 2) + Math.Pow(B.NumberY - A.NumberY, 2));

        public double PerimeterCalculator()
        {
            int maxIndexArray = _points.Length - 1;
            double perimetr = 0;

            for (int i = 0; i < _points.Length; i++)
            {
                perimetr += maxIndexArray == i
                    ? LengthSide(_points[maxIndexArray], _points[0])
                    : LengthSide(_points[i], _points[i + 1]);
            }
            return perimetr;
        }
    }
}

