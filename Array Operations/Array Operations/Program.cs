
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

int[] numbers = { 8, -3, 9, -1, 0, 1, 5, 3 };      // 8 элементов,  7 индексов

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
}

