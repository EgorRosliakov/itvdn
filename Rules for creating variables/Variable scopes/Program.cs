/*Напишите программу, в которой в теле метода Main создайте локальную переменную типа
int с именем a и проинициализируйте ее значением, полученным из консоли.
В теле метода Main создайте несколько локальных областей в которых сначала измените
значение переменной a, а затем и выведите его на экран консоли.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int a;
        Console.WriteLine(a=10);

        {
            
            a = 11;
            Console.WriteLine(a);
        }

        {
            a += 2;
            Console.WriteLine(a);
        }
       
        a += 1;
        Console.WriteLine(a);
    }
}

