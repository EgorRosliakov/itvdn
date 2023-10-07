/*Напишите программу, в которой получите от пользователя два целых числа в
переменные x и y. Для каждого из полученных чисел, используя тернарный оператор,
выполните проверку на то, является ли число четным, и если число является четным
– оставьте его значение неизменным, а если число является нечетным – увеличьте
его значение на 1.
Создайте строковую переменную result, в которую присвойте результат выполнения
тернарного оператора. В этом тернарном операторе выполните проверку на то,
делится ли сума чисел, полученная в первой части задачи, на 4 без остатка. Если
сумма делится на 4 без остатка – переменной result присвойте фразу «Сумма
значений {x} и {y} делится на 4» (используйте интерполяцию строк). Если сумма на 4
не делится – присвойте фразу «Сумма значений {x} и {y} на 4 не делится». Выведите
значение result на экран.*/

Console.WriteLine("Enter number x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberX = ((x % 2) == 0) ? x : x + 1;
int numberY = ((y % 2) == 0) ? y : y + 1;

string result = ((numberX + numberY) % 4 == 0) ? $"Sum values {x} and {y} divided by 4" :
     $"The sum of the values {x} and {y} is not divisible by 4";

Console.WriteLine(result);

/*Напишите программу, в которой:
1.Получите от пользователя два целых числа.
2. Используя выражение, в котором тернарный оператор располагается слева от
оператора присвоения, выполните проверку на то, что первое введенное число
больше или равно второму.
3. (в том же выражении) Если проверка возвращает true – первому числу должно
присвоится значение 100, иначе 100 должно присвоится второму введенному
числу.
4. Выведите информацию о числах и их итоговых значениях на экран консоли.*/

Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

/*int res = firstNumber >= secondNumber ? firstNumber += 100 : secondNumber += 100;*/

(firstNumber >= secondNumber ? ref firstNumber : ref secondNumber) += 100;

/*Console.WriteLine($"firstNumber = {firstNumber}\nsecondNumber = {secondNumber}\nres = {res}");*/
Console.WriteLine($"firstNumber = {firstNumber}\nsecondNumber = {secondNumber}");

























