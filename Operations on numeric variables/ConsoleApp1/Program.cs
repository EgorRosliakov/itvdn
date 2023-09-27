/*Создайте переменные известных вам числовых типов и присвойте им значения. Затем
создайте переменную типа sbyte и поместите в нее результат последовательного
сложения созданных ранее переменных. Вычисления выполняйте в одном выражении.
Затем создайте переменную типа short и поместите в нее результат последовательного 
вычитания созданных ранее переменных в одном выражении. Полученные результаты
выведите на экран.*/

byte numByte = 1;
sbyte numSByte = 2;
ushort numUShort = 3;
short numShort = 4;
uint numUint = 5;
int numInt = 6;
ulong numULong = 7;
long numLong = 8;
float numFloat = 9.1F;
double numDouble = 10.1;
decimal numDecimal = 11.1M;

sbyte sum = (sbyte)(numByte + numSByte + numUShort + numShort + numUint + numInt + (float)numULong + numLong + numFloat + (sbyte)numDouble + (sbyte)numDecimal);
short sum2 = sum;
Console.WriteLine(sum);
Console.WriteLine(sum);
