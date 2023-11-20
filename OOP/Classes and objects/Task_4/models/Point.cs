
namespace Task_4.models
{
    public class Point
    {
        public double NumberX { get;}
        public double NumberY { get;}
        public string PointName { get;}

        public Point(double numberX, double numberY, string pointName)
        {
            NumberX = numberX;
            NumberY = numberY;
            PointName = pointName;
        }
    }
}
