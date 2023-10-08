/*int x = 5;
int y = (--x < 5) ? x : --x;
Console.Write(y);
Console.WriteLine(++x);  //45*/

/*int x = 0, y = 0, z = 10;
(z == 10 ? x : y) = 20;
Console.WriteLine($"{x}{y}"); // не скомпелируется*/

/*  Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
    А программа сранивает два введенных числа и выводит на консоль результат сравнения 
    (два числа равны, первое число больше второго или первое число меньше второго).*/

/*Console.WriteLine("Enter first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 == num_2)
{
    Console.WriteLine("number one = number two");
}
else if (num_1 > num_2)
{
    Console.WriteLine("number one > number two");
}
else if(num_2 > num_1)
{
    Console.WriteLine("number one < number two");
}
else
{
    Console.WriteLine("ERROR");
}*/

/*  Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
    Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
    Иначе программа выводит сообщение "Неизвестное число".*/

/*Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 5 && userNumber < 10)
{
    Console.WriteLine("Number greater than 5 and less than 10");
}
else
{
    Console.WriteLine("Unknown number");
}*/

/*  Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
    Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". 
    Иначе программа выводит сообщение "Неизвестное число".*/

/*Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string res = (userNumber == 5 || userNumber == 10) ? "A number is either 5 or 10" : "Unknown number";

Console.WriteLine(res);*/

/*  В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
    Напишите консольную программу, в которую пользователь вводит сумму вклада. 
    Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
    Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
    Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())*/

/*Console.WriteLine("enter the deposit amount: ");
double userDeposit = Convert.ToDouble(Console.ReadLine());

bool percentFive = userDeposit < 100;
bool percentSeven = userDeposit >= 100 && userDeposit < 200;
bool percentTen = userDeposit >= 200;

double amoutWithPercentFive = userDeposit * 0.05;
double amoutWithPercentSeven = userDeposit * 0.07;
double amoutWithPercentTen = userDeposit * 0.1;

if (percentFive)
{
    Console.WriteLine($"You amount {userDeposit} + percent {amoutWithPercentFive} = {userDeposit + amoutWithPercentFive}");
}
else if (percentSeven)
{
    Console.WriteLine($"You amount {userDeposit} + percent {amoutWithPercentSeven} = {userDeposit + amoutWithPercentSeven}");
}
else if (percentTen)
{
    Console.WriteLine($"You amount {userDeposit} + percent {amoutWithPercentTen} = {userDeposit + amoutWithPercentTen}");
}
else
{
    ;
}*/

/*  Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
    И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
    Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.*/

/*Console.WriteLine("enter the deposit amount: ");
double userDeposit = Convert.ToDouble(Console.ReadLine());

bool percentFive = userDeposit < 100;
bool percentSeven = userDeposit >= 100 && userDeposit < 200;
bool percentTen = userDeposit >= 200;

const double bonus = 15;
double percent = default;

if (percentFive)
{
    percent = userDeposit * 0.05;
}
else if (percentSeven)
{
    percent = userDeposit * 0.07;
}
else if (percentTen)
{
    percent = userDeposit * 0.1;
}
Console.WriteLine($"You amount {userDeposit} + percent {percent} + bonus {bonus} = {userDeposit + percent + bonus}");*/

/* Напишите консольную программу, которая выводит пользователю сообщение 
   "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
   Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 
   2.Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
   Для определения операции по введенному номеру используйте конструкцию switch...case.
  Если введенное пользователем число не соответствует никакой операции (например, число 120), 
  то выведите пользователю сообщение о том, что операция неопределена.*/

/*Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение ");
int userNumber = Convert.ToInt32(Console.ReadLine());

const int addition = 1;
const int subtraction = 2;
const int multiplication = 3;

switch (userNumber)
{
    case addition:
        Console.WriteLine("+");
        break;
    case subtraction:
        Console.WriteLine("-");
        break;
    case multiplication:
        Console.WriteLine("*");
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
}*/

/*Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, 
и в зависимости от номера операции с введенными числами выполняются определенные действия 
(например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.*/

Console.WriteLine("Enter first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int addition = num_1 + num_2;
int subtraction = num_1 - num_2;
int multiplication = num_1 * num_2;

switch (userNumber)
{
    case 1:
        Console.WriteLine(addition);
        break;
    case 2:
        Console.WriteLine(subtraction);
        break;
    case 3:
        Console.WriteLine(multiplication);
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
}
