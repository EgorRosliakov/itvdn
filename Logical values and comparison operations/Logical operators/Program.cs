/*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу расчета начисления премий сотрудникам. Пользователь вводит
значение выслуги лет. Премии рассчитываются согласно выслуге лет.
Если выслуга до 5 лет, премия составляет 10% от заработной платы.
Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной
платы.
Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной
платы.
Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной
платы.
Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной
платы.
Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной
платы.
Результаты расчета, выведите на экран.*/

Console.WriteLine("Enter how many years you have been working: ");
int experience = Convert.ToInt32(Console.ReadLine());

bool bonus1 = experience >= 0 && experience > 5;
bool bonus2 = experience >= 5 && experience > 10;
bool bonus3 = experience >= 10 && experience > 15;
bool bonus4 = experience >= 15 && experience > 20;
bool bonus5 = experience >= 20 && experience > 25;
bool bonus6 = experience >= 25;

const int percentTen = 10, percentFifteen = 15,
percentTwentyFive = 25,  percentThirtyFive = 35,
 percentFortyFive = 45, percentFifty = 50;

/*  HACK   bool bonusPercent = (bonus1 == percentTen)  (bonus2 == percentFifteen) *//*| (bonus3 = percentTwentyFive) |
     (bonus4 = percentThirtyFive) | (bonus5 = percentFortyFive) | (bonus6 = percentFifty)*//*;*/

Console.WriteLine($"You experience {experience} years, you have {bonusPercent}% bonus");
 


