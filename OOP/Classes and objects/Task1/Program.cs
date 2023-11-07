/*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: Создать класс с именем Rectangle. В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь. */


using Task1;

Console.WriteLine("Enter side one: ");
double userSideOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side two: ");
double userSideTwo = Convert.ToDouble(Console.ReadLine());

Rectangle specimen = new Rectangle(userSideOne, userSideTwo);

double area = specimen.AreaCalculator();

if (area == 0)
{
    Console.WriteLine("Is not valid sides");
}

double perimetr = specimen.PerimeterCalculator();

Console.WriteLine($"Perimetr: {area}  Area: {perimetr}");

