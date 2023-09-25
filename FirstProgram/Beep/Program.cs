/*Напишите простую программу, выводящую на экран фразу “Hello, world” три раза –
сначала белым цветом текста на красном фоне, затем черным цветом текста на белом
фоне и затем стандартными цветами по умолчанию.*/

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine("“Hello, world”");


Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("“Hello, world”");

Console.ResetColor();

Console.WriteLine("“Hello, world”");


