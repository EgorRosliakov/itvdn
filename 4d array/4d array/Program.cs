/*Измените решение задачи из предыдущего урока про библиотеку. Теперь,
дополнительно к предыдущему условию, библиотека состоит еще и из 3х одинаковых
комнат со стеллажами. В этой увеличенной библиотеке разместите три книги.
Напишите программу, в которой пользователь, введя название книги, может получить
информацию о ее расположении – номер комнаты, номер стеллажа, номер полки и
номер места на полке.*/


int[,,,] array = new int[3, 5, 10, 10];

var random = new Random();

string firstBook = "О дивный новый мир";
string secondBook = "Приключения Тома Сойера";
string thirdBook = "CLR via C#";

const int notExistBook = -1;

Console.WriteLine("Enter the book title: ");
string userChoise = Console.ReadLine();

string[] someBook = { firstBook, secondBook, thirdBook };

for (int q = 0; q < array.GetLength(0); q++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            for (int k = 0; k < array.GetLength(3); k++)
            {
                array[q, i, j, k] = notExistBook;
            }
        }
    }
}

for (int i = 0; i < someBook.Length; i++)
{
    int room = random.Next(0, array.GetLength(0) - 1);
    int rack = random.Next(0, array.GetLength(1) - 1);
    int row = random.Next(0, array.GetLength(2) - 1);
    int place = random.Next(0, array.GetLength(3) - 1);

    array[room, rack, row, place] = i;
}

int keyBook = notExistBook;

for (int i = 0; i < someBook.Length; i++)
{
    if (someBook[i].Equals(userChoise, StringComparison.OrdinalIgnoreCase))
    {
        keyBook = i;
        break;
    }
}

if (keyBook == notExistBook)
{
    Console.WriteLine("Book is not found");
}
else
    for (int q = 0; q < array.GetLength(0); q++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                for (int k = 0; k < array.GetLength(3); k++)
                {
                    if (array[q, i, j, k] == keyBook)
                    {
                        Console.WriteLine($"room: {q} rack: {i} row: {j}  place: {k} book name: {someBook[keyBook]}");
                        break;
                    }
                }
            }
        }
    }


for (int i = 0; i < array.GetLength(0); i++)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        for (int k = 0; k < array.GetLength(2); k++)
        {
            
            for (int i1 = 0; i1 < array.GetLength(3); i1++)
            {
                Console.Write(array[i,j,k,i1]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}