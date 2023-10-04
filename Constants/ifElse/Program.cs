/*Напишите программу, в которой в теле метода Main примите от пользователя число.
С помощью конструкции if-else реализуйте алгоритм ветвления, в котором:
Если число больше 3 – нужно увеличить значение переменной, хранящей число, на
10. Иначе – увеличить эту переменную в 10 раз. Вывести значение переменной.*/

Console.WriteLine("Enter integer number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 3)
{
    userNumber += 10;
}
else
{
    userNumber *= 10;
}
Console.WriteLine($"Number: " + userNumber);

/*Напишите программу, в которой в теле метода Main примите от пользователя три
стороны треугольника. Далее:
1.Проведите проверку – возможен ли треугольник с такими сторонами.
2. Если возможен – проверьте, является ли треугольник прямоугольным,
равносторонним и равнобедренным.
3. Выведите информацию о треугольнике на экран.*/

Console.WriteLine("Enter the length of the first side of the triangle A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the second side of the triangle B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the length of the third side of the triangle C: ");
int C = Convert.ToInt32(Console.ReadLine());

bool isCLessSumAB = A + B > C;
bool isALessSumBC = B + C > A;
bool isBLessSumAC = C + A > B;

bool isTriangle = isCLessSumAB && isALessSumBC && isBLessSumAC; // && tru если оба

if (isTriangle)    
{
    bool isPifahorA = B * B + C * C == A * A;
    bool isPifahorB = A * A + C * C == B * B;
    bool isPifahorC = A * A + B * B == C * C;

    bool isRectangular = isPifahorC || isPifahorB || isPifahorA;

    if (A == B && B == C)
    {
        Console.WriteLine("равносторонний");  // 3 3 3
    }
    else if (A == B || A == C || B == C)       // || tru если хотя бы один
    {
        Console.WriteLine("равнобедренный");  // 3 3 5
    } 
    else if (isRectangular) 
    {
        Console.WriteLine("прямоугольный");  // 3 4 5
    }
    else 
    {
        Console.WriteLine("разносторонний");  // 3 5 6
    }
}
else
{
    Console.WriteLine("не треугольник");
}