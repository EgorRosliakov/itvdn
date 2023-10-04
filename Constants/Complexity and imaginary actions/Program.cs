/*Рефакторинг кода с ДЗ*/

int g=0, x=1, y=2, z=3;

const double PI = 3.1415926535897931;

Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double value = default;
const int valueFifteen = 15;
const int valueFour = 4;
const int valueTwo = 2;

if (x > y || userNumber < valueFifteen)
{
    g = y;
    value = g + PI;      
}
else if (z == y || z < valueFour)
{
    g = z;
    value = g + PI * valueTwo;    
}

Console.WriteLine($"число g = {g}, значение value= {value}");

Console.ReadKey();