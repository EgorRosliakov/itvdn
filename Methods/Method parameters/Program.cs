/* Напишите программу, в которой создайте три метода.
Первый метод - принимает три целых числа и возвращает сумму этих чисел.
Второй метод принимает три целочисленных ref параметра, увеличивает каждый из
полученных параметров на единицу, а затем возвращает сумму этих увеличенных
значений.
Третий метод в качестве параметров принимает три целых числа и булево значение,
и возвращает целочисленное значение. Если булевый параметр содержит значение
true – третий метод вызовет метод №1 и передаст ему значения своих числовые
параметров, иначе - если булевый параметр содержит значение false - третий метод
в своем теле вызовет метод №2 и передаст ему свои числовые параметры.
Выведите на экран результат выполнения метода №3 и значение его параметров. */

int Sum(int firstNumber, int secondNumber, int thirdNumber) => firstNumber + secondNumber + thirdNumber;

int SumAndIncreasesOneParams(ref int firstNumber, ref int secondNumber, ref int thirdNumber)
{
    firstNumber++;
    secondNumber++;
    thirdNumber++;

    return firstNumber + secondNumber + thirdNumber;
}

int GetResultByBoolParam(int firstNumber, int secondNumber, int thirdNumber, bool booleanValue) => 
    booleanValue
        ? Sum(firstNumber, secondNumber, thirdNumber)
        : SumAndIncreasesOneParams(ref firstNumber, ref secondNumber, ref thirdNumber);

/*int result;

if (booleanValue)
{
    result =  Sum(firstNumber, secondNumber, thirdNumber);
}
else
{
    result =  SumAndIncreasesOneParams(ref firstNumber, ref secondNumber, ref thirdNumber);
}
return result;*/





