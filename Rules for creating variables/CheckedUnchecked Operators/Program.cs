/*Напишите программу, в которой в теле метода Main создайте две локальные
переменные типа int в которые получите числа от пользователя и проинициализируйте
ее значением, полученным из консоли.
Создайте блок, в котором, проверяя арифметические переполнения, выполните
умножение и сложение введенных чисел. Результат умножения и сложения выведите на
экран. Попробуйте вычисления с числами, явно вызывающими переполнение.*/

/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int sum, multiply;
        {
            sum = checked(firstNumber + secondNumber);
            multiply = checked(secondNumber * firstNumber);
        }
        Console.WriteLine($"sum: {sum}, multiply: {multiply}");
    }
}*/

/*Измените проект из задания 2 таким образом, чтобы у вас проверка переполнения
выполнялась по умолчанию. При этом отключите проверку переполнения для операций
умножения и сложения.*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int sum, multiply;
        {
            sum = unchecked(firstNumber + secondNumber);
            multiply = unchecked(secondNumber * firstNumber);
        }
        Console.WriteLine($"sum: {sum}, multiply: {multiply}");
    }
}