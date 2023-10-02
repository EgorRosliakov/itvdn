/*Создайте попарно переменные известных вам типов данных. Проинициализируйте эти
переменные разными значениями. Для каждой пары переменных одного типа
выполните сравнение с использованием всех известных операторов сравнения.
Выведите на экран результаты сравнения каждой пары переменных одного типа.*/

int a = 1, b = 3;
char c = 'a', d = 'b';
double f = 3.14, e = 8.8595;
string q = "Hello", w = "Word";
bool s = true, g = false;


bool isEquals = a == b;
bool isEqualsChar = c == d;
bool isEqualsDouble = f == e;
bool isEqualsString = q == w;
bool isEqualsBool = s == g;
Console.WriteLine($" a==b: {isEquals}");
Console.WriteLine($" c==d: {isEqualsChar}");
Console.WriteLine($" f==e: {isEqualsDouble}");
Console.WriteLine($" q==w: {isEqualsString}");
Console.WriteLine($" s==g: {isEqualsString}");

bool isNotEquals = a != b;
bool isNotEqualsChar = c != d;
bool isNotEqualsDouble = f != e;
bool isNotEqualsString = q != w;
bool isNotEqualsBool = s != g;
Console.WriteLine($" a!=b: {isNotEquals}");
Console.WriteLine($" c!=d: {isNotEqualsChar}");
Console.WriteLine($" f!=e: {isNotEqualsDouble}");
Console.WriteLine($" q!=w: {isNotEqualsString}");
Console.WriteLine($" s!=g: {isNotEqualsBool}");

bool isMore = a > b;
bool isMoreChar = c > d;
bool isMoreDouble = f > e;
Console.WriteLine($" a>b: {isMore}");
Console.WriteLine($" c>d: {isMoreChar}");
Console.WriteLine($" f>e: {isMoreDouble}");

bool isLess = a < b;
bool isLessChar = c < d;
bool isLessDouble = f < e;
Console.WriteLine($" a<b: {isLess}");
Console.WriteLine($" c<d: {isLessChar}");
Console.WriteLine($" f<e: {isLessDouble}");

bool isMoreOrEqual = a >= b;
bool isMoreOrEqualChar = c >= d;
bool isMoreOrEqualDouble = f >= e;
Console.WriteLine($" a>=b: {isMoreOrEqual}");
Console.WriteLine($" c>=d: {isMoreOrEqualChar}");
Console.WriteLine($" d>=e: {isMoreOrEqualDouble}");

bool isLessOrEqual = a <= b;
bool isLessOrEqualChar = c <= d;
bool isLessOrEqualDouble = f <= e;
Console.WriteLine($" a<=b: {isLessOrEqual}");
Console.WriteLine($" c<=d: {isLessOrEqualChar}");
Console.WriteLine($" f<=e: {isLessOrEqualDouble}");

Console.WriteLine("-------------------------------------------------------------------");

/*int a = 1, b = 3;
char c = 'a', d = 'b';
double f = 3.14, e = 8.8595;
string q = "Hello", w = "Word";
bool s = true, g = false;*/

bool isIntChar = a == c;
bool isIntChar1 = a != c;
bool isIntChar2 = a > c;
bool isIntChar3 = a < c;
bool isIntChar4= a >= c;
bool isIntChar5 = a <= c;
Console.WriteLine($" a==c: {isIntChar}");
Console.WriteLine($" a!=c: {isIntChar1}");
Console.WriteLine($" a>c: {isIntChar2}");
Console.WriteLine($" a<c: {isIntChar3}");
Console.WriteLine($" a>=c: {isIntChar4}");
Console.WriteLine($" a<=c: {isIntChar5}");

bool isIntDouble = b <= f;
Console.WriteLine($" b<=f: {isIntDouble}");
// int and string error
// int and bool error
// bool isCharBool = Convert.ToChar(g) >= c; exception





