/*Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание. */

using Task3.dto;
using Task3.models;

class Program
{
    static void Main(string[] args)
    {
        
        Book book = CreateBook();
        ShowBook(book);
    }

    static Book CreateBook()
    {
        Console.WriteLine("Enter the book title: ");
        string titleBook = Console.ReadLine();
        Console.WriteLine("Enter the book author: ");
        string authorBook = Console.ReadLine();
        Console.WriteLine("Enter the book content: ");
        string contentBook = Console.ReadLine();

        return new Book(titleBook, authorBook, contentBook);
    }

    static void ShowBook(Book book)
    {
        BookDTO infoBook = book.Show();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(infoBook.Title);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(infoBook.Author);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(infoBook.Content);
    }
}