/*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс с именем Address.
В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого
поля, создать свойство с двумя методами доступа.
Создать экземпляр класса Address.
В поля экземпляра записать информацию о почтовом адресе.
Выведите на экран значения полей, описывающих адрес. */

using Task2;

Address specimen = new Address();
specimen.Index = "01001";
specimen.Country = "Ukraine";
specimen.City = "Kyiv";
specimen.Street = "Boris Gmyri";
specimen.House = 17;
specimen.Apartment = 109;
Console.Write(specimen.ToString());

