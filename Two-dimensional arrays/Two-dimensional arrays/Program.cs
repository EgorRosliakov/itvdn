/*Напишите программу, в которой создайте два двумерных массива, по логике
задачи реализующих математические матрицы. Размерность массивов получите
от пользователя. Размерность массивов должна быть таковой, чтобы обеспечить
возможность умножения этих матриц. На это ограничение нужно выполнить
проверку.
При прохождении проверки, заполните массивы данными, получая их от
пользователя.
Выведите на экран результат умножения матриц.*//*

Console.WriteLine("Enter the number of rows for the first array: ");
int rowsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns for the first array: ");
int columnsFirstArray = Convert.ToInt32(Console.ReadLine());

int[,] arrayOne = new int[rowsFirstArray, columnsFirstArray];

Console.WriteLine($"first array[{rowsFirstArray},{columnsFirstArray}]");

Console.WriteLine("Enter the number of rows for the second array: ");
int rowsSecondArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns for the second array: ");
int columnsSecondArray = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwo = new int[rowsSecondArray, columnsSecondArray];

Console.WriteLine($"second array[{rowsSecondArray},{columnsSecondArray}]");

if (columnsFirstArray != rowsSecondArray)
{
    Console.WriteLine("Sorry, matrices cannot be multiplied");
}
else
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            Console.WriteLine("Enter the elements for the first array: ");
            arrayOne[i, j] = Convert.ToInt32(Console.ReadLine());           
        }
    }
    for (int x = 0; x < arrayOne.GetLength(0); x++)
    {
        for (int y = 0; y < arrayOne.GetLength(1); y++)
        {
            Console.Write(arrayOne[x, y] + "\t");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            Console.WriteLine("Enter the elements for the second array: ");
            arrayTwo[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    for (int x = 0; x < arrayTwo.GetLength(0); x++)
    {
        for (int y = 0; y < arrayTwo.GetLength(1); y++)
        {
            Console.Write(arrayTwo[x, y] + "\t");
        }
        Console.WriteLine();
    }

    int[,] arrayMultiplied = new int[rowsFirstArray, columnsSecondArray];

    Console.WriteLine("Multiplied matrix: ");

    for (int i = 0; i < arrayMultiplied.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultiplied.GetLength(1); j++)
        {
            arrayMultiplied[i, j] = 0;

            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                arrayMultiplied[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
            Console.Write($"{arrayMultiplied[i, j]} \t");
        }
        Console.WriteLine();
    }*/

    
    
        
    
    Console.ReadKey();
}

