/*Напишите программу, в которой получите от пользователя некий объем текста.
Сохраните этот текст в виде зубчатого массива, каждый элемент которого – массив
строк. Каждый массив строк должен представлять собой набор строковых элементов,
составляющих одно предложение общего текста, введенного пользователем, в
котором слова разделены пробелами.
Выведите на экран все слова, сохраненные в структуре зубчатого массива и его
элементов.*/

Console.WriteLine("Enter something text: ");
string userText = Console.ReadLine();

string[] array = userText.Split(new char[] { '.', '!', '?', ','});  // разделяем введенную строку на массив подстрок

string[][] arrayGlobal = new string[array.Length][];

for (int i = 0; i < array.Length; i++)
{
    arrayGlobal[i] = array[i].Split(" ");
}

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < arrayGlobal[i].Length; j++)
    {
        Console.Write($"{arrayGlobal[i][j]} ");
    }
    Console.WriteLine();
}















/*string[] array1 = { "Yehor", "Oksana", "Veronika" };
string[] array2 = { "Sergey", "Tanya" };

string[][] array3 = new string[2][] { array1, array2 };

for (int i = 0; i < array3.Length; i++)
{
    for (int j = 0; j < array3[i].Length; j++)
    {
        Console.Write(array3[i][j] + " ");
    }
    Console.WriteLine();
}*/