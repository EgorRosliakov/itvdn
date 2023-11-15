
namespace Task_4.models
{
    public class Point
    {
        public double NumberX { get;}
        public double NumberY { get;}
        public string PointName { get;}

       /* private double _numberX;
        private double _numberY;
        private string _pointName;

        public double NumberX 
        {
            get => _numberX;          
        }
        public double NumberY
        {
            get => _numberY;          
        }
        public string PointName
        {
            get => _pointName;          
        }*/

        public Point(double numberX, double numberY, string pointName)
        {
            NumberX = numberX;
            NumberY = numberY;
            PointName = pointName;
        }
    }
}
