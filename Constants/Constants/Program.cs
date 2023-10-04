/*Напишите программу, в которой в теле метода Main создайте две константы - с именем PI,
которой присвойте значение 3,141593, и с именем MY_CONST, которой присвойте значение
true.
Выполните сравнение того значения, которое ввел пользователь, с тем значением, которое
хранится в константе PI и сохраните результат сравнения в переменную с именем
iSConstBigger. Далее, проверьте на равенство значение переменной iSConstBigger со
значением MY_CONST. Результат последнего сравнения выведите на экран консоли.*/

const double PI = 3.141593;
const bool MY_CONST = true;

Console.WriteLine("Enter you value: ");
double userValue = Convert.ToDouble(Console.ReadLine());

bool iSConstBigger = Convert.ToBoolean(userValue == PI);

bool equalityTest = iSConstBigger == MY_CONST;
Console.WriteLine(equalityTest);



