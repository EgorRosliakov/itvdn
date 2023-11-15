/*Создать классы Point и Figure.
Класс Point должен содержать два целочисленных поля и одно строковое поле.
Создать три свойства с одним методом доступа get.
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.
Написать программу, которая выводит на экран название и периметр многоугольника. */

using Task_4.models;
using Task_4.dto;
class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 4, "B");
        Point point3 = new Point(3, 0, "C");


        Figure triangle = new Figure(point1, point2, point3);
        triangle.PerimeterCalculator();

        /*Point[] points = new Point[5];

        int numberOfPoints = 0;

        do
        {
            Console.WriteLine($"Enter coordinates for Point {numberOfPoints + 1}:");
            points[numberOfPoints] = CreatePointFromUserInput();
            numberOfPoints++;

            if (numberOfPoints < points.Length)
            {
                Console.Write($"Do you want to enter another point? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response != "yes")
                    break;
            }
        } while (numberOfPoints < points.Length);

        Figure polygon = new Figure(points[0], points[1], points[2], points[3], points[4]);

        polygon.PerimeterCalculator();

        static Point CreatePointFromUserInput()
        {
            Console.WriteLine("Enter X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Point name: ");
            string name = Console.ReadLine();

            return new Point(x, y, name);
        }*/
    }
}

