/*Напишите программу, в которой создайте массив строковых элементов. В блоке
инициализатора заполните массив названиями месяцев по порядку. Далее создайте
цикл, в котором выведите на экран консоли все содержимое массива строк. */

/*string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

int index = 0;

while (index < monthName.Length)
{
    string month = monthName[index];
    Console.WriteLine(month);

    index++;
}*/

/*Напишите программу, в которой воспользуйтесь массивом строк из предыдущего
задания.
Создайте цикл, в котором обратитесь к пользователю. Пользователь для первой
итерации цикла должен ввести строковое значение первого по порядку месяца, для
второй итерации – строковое значение второго месяца и так далее до конца массива.
Если пользователь введет неправильно текущее значение месяца – итерация цикла
должна повториться с тем, чтобы пользователь попробовал ввести значение еще
раз. Если пользователь ошибется при вводе значения 5го месяца – цикл должен
прекратить свою работу.*/

string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

int index = 0;  // значимый тип - копирование данных(если что то делаем, основное значение не меняется) // ссылочный тип только string - мы обращаемся к оригиналу и меняем его.
const int FIVE_MONTH = 4;

while (index < monthName.Length)
{
    Console.WriteLine($"Enter name of month: {monthName[index]}");
    string userInput = Console.ReadLine();

    if (userInput == monthName[index])
    {
        Console.WriteLine("correct");
    }

    else if (index == FIVE_MONTH && userInput != monthName[index])
    {
        Console.WriteLine("Sorry");
        break;
    }

    else 
    {      
        Console.WriteLine("Error, try again");
        continue;
    }
    index++;
}