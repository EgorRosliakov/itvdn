
/*int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[5];

int index = 0;

while (index < array1.Length)
{
    array1.CopyTo(array2, 0);                        // CopyTo 
    Console.WriteLine(array2[index]);
    array1[2] = 7;
    index++;
}*/

/*int[] array = { 1, 2, 3, 4, 5 };

Array.Resize(ref array, 9);                         // Resize

int index = 0;
while (index < array.Length)
{
    Console.WriteLine(array[index]);
    index++;
}*/

/*int[] array = new int[5] { 5, 6, 2, 1, 9 };

int index = 0;

while (index < array.Length)
{
    Array.Sort(array);                              // Sort
    Console.Write(array[index]);
    index++;
}*/


/*int[] array = { 2, 3, 4, 5, 6, 7 };

int index = 0;

Array.Reverse(array);  
                                                    // Reverse
while (index < array.Length)
{
    Console.Write(array[index]);
    index++;
}*/

/*int[] array = { 1, 2, 3 };*/
/*int[] array = new int[3];*/
/*int[] array = new int[] { 1, 2, 3 };*/
/*int[] array = new int[3] { 1, 2, 3 };*/

/*Найдем количество положительных чисел в массиве:*/

/*int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int index = 0;

while (index < numbers.Length)
{
        if (numbers[index] > 0)
    {
        Console.Write(numbers[index]);
    }
    index++;
}*/

// Cортировка пузырьком

/*int[] numbers = { 8, -3, 9, -1, 0, 1, 5, 3, 4 };

int i = 0;

while (i < numbers.Length - 1)
{
    int j = i + 1;
    while (j < numbers.Length)
    {
        if (numbers[i] < numbers[j])
        {
            int temp;
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        j++;
    }
    i++;
}

i = 0;
while (i < numbers.Length)
{
    Console.Write(numbers[i]);
    i++;
}*/

/*Напишите программу, в которой:
1.получите от пользователя целое число.
2. Создайте массив целочисленных элементов, длинной с полученное число.
3. С помощью цикла и обращаясь за значениями к пользователю заполните массив
целочисленных элементов.
4. Отсортируйте массив по убыванию, после чего измените размер массива на +1
элемент.
5. Обратитесь к пользователю и заполните новый элемент массива значением от
пользователя.*/

/*Console.WriteLine("Enter integer number: ");
int userInteger = Convert.ToInt32(Console.ReadLine());

int[] integerArray = new int[userInteger];

int index = 0;

while (index < integerArray.Length)
{
    Console.WriteLine("Enter elements array: ");
    int userElements = Convert.ToInt32(Console.ReadLine());
    integerArray[index++] = userElements;

    *//*index++;*//*
}

Array.Resize(ref integerArray, integerArray.Length + 1);
Console.WriteLine("Enter new element: ");
integerArray[integerArray.Length - 1] = Convert.ToInt32(Console.ReadLine());

*//*index = 0;
while (index < integerArray.Length - 1)
{
    int z = index + 1;
    while (z < integerArray.Length)
    {
        int temp;
        if (integerArray[index] < integerArray[z])
        {
            temp = integerArray[index];
            integerArray[index] = integerArray[z];
            integerArray[z] = temp;
        }
        z++;
    }
    index++;
}*//*

Array.Sort(integerArray);
Array.Reverse(integerArray);

index = 0;
while (index < integerArray.Length)
    Console.Write(integerArray[index++]);
    //index++;*/


/*Есть массив, найти определенный елемент*/

/*int[] numbers = { 8, -3, 9, -1, 0, 1, 5, 3 };      // 8 элементов,  7 индексов

Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

bool found = false;

int index = 0;

while (index < numbers.Length)
{
    if (numbers[index] == userNumber)
    {
        found = true;
        break;
    }
    index++;
}

if (found)
{
    Console.WriteLine($"there is such an element in the array: {numbers[index]}");
}
else
{
    Console.WriteLine("there is no such element");
}*/



/*вывести четные и нечетные елементы в массиве*/

/*int[] array = new int[] { -2, 1, -8, 3, 8, -3, 7, 4, -8, 6 };

int index = 0;

Console.WriteLine("Even numbers: ");

while (index < array.Length)
{
    if (array[index] % 2 == 0)
        Console.Write(array[index]);
    index++;
}

Console.WriteLine("\nOdd numbers: ");
index = 0;
while (index < array.Length)
{
    if (array[index] % 2 != 0)
        Console.Write(array[index]);
    index++;
}*/


/*есть массив, удалить 1 элемент*/

/*int[] array = new int[] { -2, 1, -8, 3, 8, -3, 7, 4, -8, 6 };

Console.WriteLine("We have array: ");

int index = 0;
while (index < array.Length)
{
    Console.Write(array[index]);
    index++;
}

Console.WriteLine("\nWhat element you want remove?: ");
int userRemove = Convert.ToInt32(Console.ReadLine());

int countRemove = 0;

index = 0;

while (index < array.Length)
{
    if (array[index] == userRemove)
    {
        countRemove++;
    }
    index++;
}

int[] newArray = new int[array.Length - countRemove];
int newIndex = 0;

index = 0;
while (index < array.Length)
{
    if (array[index] != userRemove)
    {
        newArray[newIndex] = array[index]
            ; newIndex++;
    }
    index++;
}

index = 0;
while (index < newArray.Length)
{
    Console.Write(newArray[index]);
    index++;
}*/

/*for(int x = 5, y = 10; x < y; x++, y--)
{
    Console.WriteLine(x + y);
}*/

/*int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = array.Length - 5; i < array.Length; i += 2)

{

    Console.Write(array[i]);

}*/

/*Напишите программу, в которой, используя конструкции цикла со счетчиком:
1.Выведите на экран консоли все числа от 0 до 100;
2.Выведите на экран числа от 1001 до 2500 с шагом – 3;
3.Выведите числа от 100 до 0 с шагом – 4;
4.Выведите числа от 1 до 5 с шагом 0,2.*/

/*for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
}*/

/*for (int i = 1001; i <= 2500; i+=3)
{
    Console.WriteLine(i);
}*/

/*for (int i = 100; i >= 0; i -= 4)
{
    Console.WriteLine(i);
}*/

/*for (double i = 1; i < 5; i += 0.2)
{
    Console.WriteLine(i);
}*/

/*Console.WriteLine("Enter number y: ");
int y = Convert.ToInt32(Console.ReadLine());

int x = 0;

while (x < y)
{
    Console.SetCursorPosition(y - x, x + 2);
    int z = 0;
    while (z <= x * 2)
    {
        Console.Write("*");
        z++;
    }
    Console.WriteLine();
    x++;
}
*/

int high = 6;
int margin = high - 1;  // отступ от левого края
int starCount = 1;      // количество * для первой строки
int start = 0;          // счетчик строк

while (high > start)    // цикл для высоты треугольника
{
    int startMargin = 0;  // счетчик для отступа слева

    while (margin > startMargin)  // cоздаем отступ слева
    {
        Console.Write(" ");
        startMargin++;
    }

    startMargin = 0;

    while (starCount > startMargin)  // создание строки
    {
        if (start == 0 || start == high - 1 || startMargin == 0 || startMargin == starCount - 1)
           // Если находимся на краях треугольника или на границах строки
            Console.Write("*");
        else
            Console.Write(" ");
        startMargin++;
    }

    Console.WriteLine();

    margin--;  // уменьшаем отступ от левого края при переходе на новую строку
    starCount += 2; // увеличиваем количество * для новой строки
    start++;
}