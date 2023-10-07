/*Напишите программу, в которой примите от пользователя значения двух длин
сторон прямоугольника. Далее пользователь вводит строковую команду «площадь»
или «периметр». Если пользователь ввел «площадь» - вывести на экран значение
площади фигуры. Если пользователь ввел «периметр» - вывести на экран значение
периметра. Если пользователь ввел какую-либо другую строку – выведите
«Неверная команда!».
Если прямоугольник является квадратом – дополнительно выведите на экран фразу:
«данный прямоугольник – квадрат».*/

Console.WriteLine("Enter first lenght of rectangle: ");
uint firstLenght = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Enter second lenght of rectangle: ");
uint secondLenght = Convert.ToUInt32(Console.ReadLine());

bool isSquare = firstLenght == secondLenght;

if (isSquare)
{
    Console.WriteLine("This rectangle is a square");
}
else
{
    Console.WriteLine("Enter what you want count: area or perimeter");
    string userChoice = Console.ReadLine();

    if (userChoice.Equals("area", StringComparison.OrdinalIgnoreCase))
    {
        uint area_rectangle = firstLenght * secondLenght;
        Console.WriteLine($"firstLenght: {firstLenght}, secondLenght: {secondLenght}, area_rectangle: {area_rectangle}");
    }
    else if (userChoice == "perimeter")
    {
        uint perimeter_rectangle = firstLenght + secondLenght * 2;
        Console.WriteLine($"firstLenght: {firstLenght}, secondLenght: {secondLenght}, area_rectangle: {perimeter_rectangle}");
    }
    else
    {
        Console.WriteLine("Invalid command");
    }
}


/*Пользователь вводит 4 числа. Найти наибольшее четное. Если такого нет – вывести
«Not found». Если есть – вывести его. (Решите задачу с использованием условных
конструкций)*/

Console.WriteLine("Enter first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter fourth number: ");
int num_4 = Convert.ToInt32(Console.ReadLine());

int maxNumberFirstSecond = Math.Max(num_1, num_2);
int maxNumberThirdFourth = Math.Max(num_3, num_4);
int maxNumbers = Math.Max(maxNumberFirstSecond, maxNumberThirdFourth);

if ((maxNumbers % 2) == 0)
{
    Console.WriteLine($"Greatest even: {maxNumbers} ");
}
else
{
    Console.WriteLine($"Greatest even: Not found ");
}

