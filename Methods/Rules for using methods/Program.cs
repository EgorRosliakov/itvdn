/*Создать набор перегрузок метода PrintResult:
◦ Принимает 3 целочисленные переменные и выводит на экран
результат их сложения.
◦ Принимает 3 целочисленные переменные и выводит на экран
результат их разности.
◦ Принимает 2 целочисленные переменные и выводит первое число
в степени второго.
◦ Принимает 3 целочисленные переменные и вводит на экран сумму
значений этих переменных представленных в строковом виде
(пример: «3» + «4» + «5»).*/

class Program
{ 
    public static void PrintResult(int firstNumber, int secondNumber, int thirdNumber)
    {
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum: " + sum);
    }
    public static void PrintResult(long firstNumber, long secondNumber, long thirdNumber)
    {
        long difference = firstNumber - secondNumber - thirdNumber;
        Console.WriteLine("Difference" + difference);
    }
    public static void PrintResult(int firstNumber, int secondNumber)
    {
        int numberDegree = Convert.ToInt32(Math.Pow(firstNumber, secondNumber));
        Console.WriteLine("Number to a degree: " + numberDegree);
    }
    public static void PrintResult(short firstNumber, short secondNumber, short thirdNumber)
    {
        string result = firstNumber.ToString() + "+" + secondNumber.ToString() + "+" + thirdNumber.ToString();
        Console.WriteLine("Amount as a string: " + result);
    }

    static void Main()
    {
      PrintResult()
    }
}

