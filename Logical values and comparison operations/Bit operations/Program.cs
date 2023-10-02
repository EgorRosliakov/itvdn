/*Имеется 3 переменные типа int x = 5, y = 10, и z = 15;
Выполните и рассчитайте результат следующих операций для этих переменных:
x += y >> x++ * z;
z = ++x & y * 5; // 
y /= x + 5 | z;
z = x++ & y * 5;
x = y << x++ ^ z;*/

int x = 5, y = 10, z = 15;
x += y >> x++ * z; // 
Console.WriteLine($"{x}, {y}, {z}");

z = ++x & y * 5;
Console.WriteLine($"{x}, {y}, {z}");

y /= x + 5 | z;
Console.WriteLine($"{x}, {y}, {z}");

z = x++ & y * 5;
Console.WriteLine($"{x}, {y}, {z}");

x = y << x++ ^ z;
Console.WriteLine($"{x}, {y}, {z}");
/*
Напишите программу, выполняющую «зашифровку» и «расшифровку» введенного
пользователем символа. Ключом шифрования считайте число 216. Выведите на экран
консоли зашифрованный символ и расшифрованный.*/

char symbol = 'Y';
int key = 216;
Console.WriteLine($"original = {symbol}");

char encryption = (char)(symbol ^ key);
Console.WriteLine($"encryption = {encryption}");

char encryption1 = (char)(encryption ^ key);
Console.WriteLine($"transcript = {encryption1}");



Console.Write("Фамилия запросившего субсидию: ");
string name = Console.ReadLine();

Console.Write($"{name} является пенсионером? : ");
bool isPensioner = Console.ReadLine().Contains("да");

Console.Write($"{name} состоит на учёте в службе занятости? : ");
bool isUnemployed = Console.ReadLine().Contains("да");

Console.Write($"{name} имеет трудоустройство? : ");
bool isEmployment = Console.ReadLine().Contains("да");

bool subsidyAllowed = (isPensioner | isUnemployed) || !isEmployment;

Console.Write($"{name} имеет право на субсидию : {subsidyAllowed}");
Console.ReadKey();