/*Выполните преобразования переменной типа decimal, хранящей в себе значение
3,1415926536 во все известные вам числовые типы.*/

decimal a = 3.1415926536M;
Console.WriteLine(a);
byte b = (byte) a;
Console.WriteLine(b);
sbyte c = (sbyte) a;
Console.WriteLine(c);
short r = (short) a;
Console.WriteLine(r);
ushort s = (ushort) a;
Console.WriteLine(s);
int d = (int) a;
Console.WriteLine(d);
uint e = (uint) a;
Console.WriteLine(e);
long l = (long) a;
Console.WriteLine(l);
ulong q = (ulong) a;
Console.WriteLine(q);
float f = (float) a;
Console.WriteLine(f);
double g = (double) a;
Console.WriteLine(g);
Console.WriteLine("-----------------------------");

/*Создайте переменную типа float и поместите в нее число, равное 2,7182818284590452.
Выполните преобразование значения переменной во все известные числовые типы. При
создании переменных используйте полные имена типов, а не алиасы. Выведите значения
каждой переменной на экран. Используйте безопасное приведение*/

Single numberFloat = 2.7182818284590452F;
Console.WriteLine(numberFloat);
System.Double numberDouble = numberFloat;
Console.WriteLine(numberDouble);
System.Decimal numberDecimal = (decimal)numberFloat;
Console.WriteLine(numberDecimal);



Int16 numberInt16 = (Int16) numberFloat;
Console.WriteLine(numberInt16);
UInt16 numberUInt16 = (UInt16) numberFloat;
Console.WriteLine(numberUInt16);
Int32 numberInt32 = (Int32) numberFloat;
Console.WriteLine(numberInt32);
UInt32 numberUInt32 = (UInt32) numberFloat;
Console.WriteLine(numberUInt32);
Int64 numberInt64 = (Int64) numberFloat;
Console.WriteLine(numberInt64);
UInt64 numberUInt64 = (UInt64) numberFloat;
Console.WriteLine(numberUInt64);



