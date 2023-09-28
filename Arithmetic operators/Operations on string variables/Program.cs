/*Напишите приложение, в котором программа получает и сохраняет в отдельные
переменные от пользователя сначала его имя, потом его фамилию, а затем выводит на
экран строку по типу “Hello <Имя_пользователя> <Фамилия пользователя>! It`s a god
day today!” Данный текст должен быть составлен одной строкой, при этом после
первого предложения должен выполняться перенос строки на новую с использованием
escape-последовательности.*/


Console.Write("Enter you name: ");string customerName = Console.ReadLine();Console.Write("Enter you surname: ");string customerSurname = Console.ReadLine();Console.WriteLine($"Hello {customerName} {customerSurname}!\nIt`s a god day today!");