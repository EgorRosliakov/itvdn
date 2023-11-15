
using Task_4.dto;

namespace Task_4.models
{
    public class Figure
    {
        private Point[] _points;

        private int _countSides;

        private Point _sidesOne;
        private Point _sidesTwo;
        private Point _sidesThree;
        private Point _sidesFour;
        private Point _sidesFive;

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree)
        {
            _sidesOne = sidesOne;
            _sidesTwo = sidesTwo;
            _sidesThree = sidesThree;

            _countSides = 3;

            InitArrayPoints();
        }

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree, Point sidesFour)
            : this(sidesOne, sidesTwo, sidesThree)
        {
            _sidesFour = sidesFour;

            _countSides = 4;

            InitArrayPoints();
        }

        public Figure(Point sidesOne, Point sidesTwo, Point sidesThree, Point sidesFour, Point sidesFive)
            : this(sidesOne, sidesTwo, sidesThree, sidesFour)
        {
            _sidesFive = sidesFive;

            _countSides = 5;

            InitArrayPoints();
        }

        public double LengthSide(Point A, Point B) 
            => Math.Sqrt(Math.Pow(B.NumberX - A.NumberX, 2) + Math.Pow(B.NumberY - A.NumberY, 2));       

        private void InitArrayPoints()
        {
            _points = new[] {_sidesOne, _sidesTwo, _sidesThree, _sidesFour, _sidesFive};
        }

        public double PerimeterCalculator()
        {

        }

       /* public void PerimeterCalculator()
        {
            double perimetr = 0;
            string Naim = string.Empty;

            if (_sidesFive != null)
            {
                Naim = "pentagon";
                perimetr += LengthSide(_sidesOne, _sidesTwo);
                perimetr += LengthSide(_sidesTwo, _sidesThree);
                perimetr += LengthSide(_sidesThree, _sidesFour);
                perimetr += LengthSide(_sidesFour, _sidesFive);
                perimetr += LengthSide(_sidesFive, _sidesOne);
            }
            else if (_sidesFour != null)
            {
                Naim = "quadrilateral";
                perimetr += LengthSide(_sidesOne, _sidesTwo);
                perimetr += LengthSide(_sidesTwo, _sidesThree);
                perimetr += LengthSide(_sidesThree, _sidesFour);
                perimetr += LengthSide(_sidesFour, _sidesOne);
            }
            else
            {
                Naim = "triangle";
                perimetr += LengthSide(_sidesOne, _sidesTwo);
                perimetr += LengthSide(_sidesTwo, _sidesThree);
                perimetr += LengthSide(_sidesThree, _sidesOne);
            }

            Console.WriteLine($"Polygon name: {Naim}");
            Console.WriteLine($"Polygon perimeter: {perimetr}");
        }*/
    }
}

