/*Имеется библиотека, в которой находится 5 стеллажей с книгами. Каждый стеллаж
является типовым – в нем имеется 10 полок и на каждой полке помещается по 10 книг.
Для хранения информации о том, на каком стеллаже, на какой полке и в каком месте
этой полки хранится книга – в библиотечной базе данных используется массив строк с
названиями книг.
Реализуйте такой способ хранения информации о книгах в вашей программе. В вашей
библиотеке на разных стеллажах, разных полках и разных местах на полках поместили 3
книги: «О дивный новый мир», «Приключения Тома Сойера» и «CLR via C#».
Напишите программу, в которой пользователь, введя название книги, может получить
информацию о ее расположении – номер стеллажа, номер полки и номер места на полке.*/

int[,,] array = new int[5, 10, 10];

var random = new Random();

string firstBook = "О дивный новый мир";
string secondBook = "Приключения Тома Сойера";
string thirdBook = "CLR via C#";

const int notExistBook = -1;

Console.WriteLine("Enter the book title: ");
string userChoise = Console.ReadLine();

string[] someBook = { firstBook, secondBook, thirdBook };

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = notExistBook;
        }
    }
}

for (int i = 0; i < someBook.Length; i++)
{
    int rack = random.Next(0, array.GetLength(0) - 1);
    int row = random.Next(0, array.GetLength(1) - 1);
    int place = random.Next(0, array.GetLength(2) - 1);

    array[rack, row, place] = i;
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

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == keyBook)
                {
                    Console.WriteLine($"rack: {i} row: {j}  place: {k} book name: {someBook[keyBook]}");
                    break;
                }
            }
        }
    }









