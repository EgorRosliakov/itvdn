namespace Task1
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator() =>
            IsValidSides()
                ? side1 * side2
                : 0;

        public double PerimeterCalculator() =>
            IsValidSides()
                ? 2 * (side1 + side2)
                : 0;

        private bool IsValidSides() => side1 > 0 && side2 > 0 && side1 != side2;

        public double Area
        {
            get => side1 * side2;
        }

        public double Perimeter
        {
            get => 2 * (side1 + side2);
        }
    }
}
