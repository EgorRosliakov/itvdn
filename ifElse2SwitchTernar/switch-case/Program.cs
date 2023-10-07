/*Напишите программу – консольный калькулятор.
Создайте две вещественные переменные и запросите от пользователя значения этих
переменных. Предложите пользователю ввести знак арифметической операции.
Используя конструкцию switch-case, в зависимости от введенного символа
выполните арифметическую операцию сложения, вычитания, умножения или
деления между вещественными переменными. Выведите результат на экран.
В случае деления – выполните дополнительную проверку делителя, чтобы не
выполнить деление на ноль и отмените выполнение математической операции.
Если пользователь ввел неподходящий символ – выведите на экран “Неподходящий
символ».*/

Console.WriteLine("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter sign: +  -  *  /  ");
string userSign = Console.ReadLine();

switch (userSign)
{
    case "+":
        {
            double addition = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber}+{secondNumber}={addition}");
            break;
        }
    case "-":
        {
            double subtraction = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber}-{secondNumber}={subtraction}");
            break;
        }
    case "*":
        {
            double multiplication = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber}*{secondNumber}={multiplication}");
            break;
        }
    case "/":
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("You can't divide by zero");
            }
            else
            {
                double divisions = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber}/{secondNumber}={divisions}");
            }
                break;
            
        }
    default:
        {
            Console.WriteLine("Unsuitable symbol");
            break;
        }
}

