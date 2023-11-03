/*Создайте метод, в теле которого происходит вычисление факториала числа
рекурсивно. Прошагайте и выведите на экран результат вычисления факториала 5.
Создайте другой метод, в котором вычисление факториала числа реализуйте с
помощью циклов.
Вычислите значения факториалов для 5, 6, 10, 100.*/



using System.Numerics;

/*BigInteger GetFactorial(BigInteger someNumber) =>
    (someNumber == 0 || someNumber == 1)
        ? 1
        : someNumber * GetFactorial(someNumber - 1);

BigInteger someNumber = GetFactorial(5);
Console.WriteLine("5!=" + someNumber);*/

/*int GetArray(int[] array, int i = 0) 
{
    if (i < array.Length)
    {
        Console.WriteLine(array[i]);
        return GetArray(array, i + 1);
    }
    return 0;
}

int[] array = { 10, 2, 3, 4, 5 };
GetArray(array);*/

void ShowArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        Console.WriteLine(array[i]);
        ShowArray(array, i + 1);
    }
}

int[] array = { 10, 2, 3, 4, 5 };
ShowArray(array);




BigInteger GetFactorial(BigInteger userNumber)
{
    BigInteger factorial = 1;

    if (userNumber == 0)
        return factorial;

    for (BigInteger i = 1; i <= userNumber; i++)
        factorial *= i;

    return factorial;
}

/*Console.WriteLine("Enter you number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{userNumber}!=" + GetFactorial(userNumber));*/

Console.WriteLine("5!=" + GetFactorial(5));
Console.WriteLine("6!=" + GetFactorial(6));
Console.WriteLine("10!=" + GetFactorial(10));
Console.WriteLine("100!=" + GetFactorial(100));

