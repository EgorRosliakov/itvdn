/*Напишите программу, в которой получите целое число и используя циклическую
конструкцию выведите на экран консоли все числа от введенного и до нуля
включительно.*/

/*Console.WriteLine("Enter integer number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 0)
{
    while (userNumber <= 0)
    {
        Console.WriteLine(userNumber);
        userNumber++;
    }
}
else while (userNumber >= 0)
    {
        Console.WriteLine(userNumber);
        userNumber--;
    }
*/

/*Напишите программу, в которой получите от пользователя два целых числа.
Используя цикл выведите все нечетные числа, расположенные между введенными
числами.*/

/*Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}*/

/*while (firstNumber <= secondNumber)
{

    if (firstNumber % 2 != 0)
    {
        Console.WriteLine($"{firstNumber}");
    }
    firstNumber++;
}*/

/*if (firstNumber % 2 == 0)
{
    firstNumber++;
}

while (firstNumber <= secondNumber)
{
    Console.WriteLine($"{firstNumber}");
    firstNumber += 2;
}*/




/*int a = 5;
int i = 0;*/

/*

* 
**
***
****
*****

 */

/*while (i < a)
{
    int j = 0;
    while (i >= j)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}*/

/*

*****
****
***
**
*

 */

/*int a = 5;
int i = 0;

while (i < a)
{
    int j = a;
    while ( i < j)
    {
        Console.Write("*");
        j--;
    }
    Console.WriteLine();
    i++;
}
*/


/*    
    *
   **
  ***
 ****
*****

 */

/*while (i < a)
{
    int j = a;
    while (i < j)
    {
        Console.Write(" ");
        j--;
    }
    j = 0;
    while (i >= j)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}*/

/*
  
 *****
  ****
   ***
    **
     *
    
 */

/*while (i < a)
{
    int j = 0;
    while (i >= j)
    {
        Console.Write(" ");
        j++;
    }
    j = a;
    while (i < j)
    {
        Console.Write("*");
        j--;
    }
    Console.WriteLine();
    i++;
}*/

/*
  
*****
*****
*****
*****
*****

 */

/*while (i < a)
{
    int j = 0;
    while (a > j)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}*/


/*  
   
    *
   ***
  *****
 *******
*********

 */

Console.WriteLine("Enter number y: ");
int y = Convert.ToInt32(Console.ReadLine());

int x = 0;

while (x < y)
{
    Console.SetCursorPosition(y - x, x + 2);
    int z = 0;
    while (z <= x * 2)
    {
        Console.Write("*");
        z++;
    }
    Console.WriteLine();
    x++;
}

/*int high = 6;
int margin = high - 1;
int starCount = 1;

int start = 0;

while (high > start)
{
    int startMargin = 0;

    while (margin > startMargin)
    {
        Console.Write(" ");
        startMargin++;
    }

    startMargin = 0;

    while (starCount > startMargin)
    {
        Console.Write("*");
        startMargin++;
    }

    Console.WriteLine();

    margin--;
    starCount += 2;
    start++;
}*/



/*Console.WriteLine("enter a: ");
int a = Convert.ToInt32(Console.ReadLine());*/

/*int a = 3;
int i = 0;*/

/*while (i < a)     // 2. переход на вторую строку
{
    int j = 0;
    while (j < a)
    {
        Console.Write("*"); // 1. *** в ряд, и переход в верхний цикл    ***
        j++;                                                             ***
    }                                                                    ***
    Console.WriteLine();
    i++;
}*/

/*while (i < a)
{
    int j = 0;
    while (j <= i)                                *
    {                                             **
        Console.Write("*");                       ***
        j++;
    }
    Console.WriteLine();
    i++;
}*/

/*while (i < a)
{
    int j = a;
    while (j > i)
    {
        Console.Write("*");       ***
        j--;                      **
    }                             *
    Console.WriteLine();
    i++;
}*/

/*while (i < a)
{
    int j = 0;
    while (i >= j)
    {
        Console.Write(" ");       ***
        j++;                       **
    }                               *
    int k = a;
    while (i < k)
    {
        Console.Write("*");
        k--;
    }
    Console.WriteLine();
    i++;
}*/

/*while (i < a)
{
    int j = a;
    while (j > i)
    {
        Console.Write(" ");                 *
        j--;                               **   
    }                                     ***              
    int z = 0;
    while (i >= z)
    {
        Console.Write("*");
        z++;
    }
    Console.WriteLine();                         
    i++;                                        
}*/


