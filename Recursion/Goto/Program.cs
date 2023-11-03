/*Используя оператор goto реализуйте логику циклов while, do-while и for. Также
реализуйте такие же бесконечные циклы.*/


int someNumber = 10;

int i = 0;

Label:
if (i <= someNumber)
{
Console.WriteLine(i);
i++;
goto Label;
}



/*Label:
Console.WriteLine(i);
i++;
if (i <= someNumber) 
goto Label;*/

/*Label:
Console.WriteLine(i);
i++;
if (i <= someNumber) ;
goto Label;*/

/*Label:
i = 0;
Console.WriteLine(i);
i++;
goto Label;*/