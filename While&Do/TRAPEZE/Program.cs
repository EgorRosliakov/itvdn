Console.WriteLine("Enter hight: ");
int hight = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());

/*int topWidth = width - 2 * hight; // формула для вверха

int counter = 0;

while (counter < hight)
{
    int i = 0;
    while (i < width)
    {
        if (i >= (width - topWidth) / 2 && i < (width + topWidth) / 2)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
        i++;
    }
    Console.WriteLine();
    topWidth += 2;
    width += 4;
    counter++;
}*/




if (hight > width)
{
    int temp = hight;
    hight = width;
    width = temp;
}

if (hight < 1 || width < 1)
{
    Console.WriteLine("Error, enter correct values");
}
else
{
    int counter = 0;
    while (counter < hight)
    {
        int z = hight - counter - 1;
        int i = 0;
        while (i < z)
        {
            Console.Write(" ");
            i++;
        }
         i = 0;
        while (i < width - 2 * z)
        {
            Console.Write("*");
            i++;
        }
        Console.WriteLine();
        counter++;
    }
}


/*int counter = 0;
while (counter < hight)
{
    int i = hight;

    while (i > 1)
    {
        Console.Write("  ");
        i--;
    }
    int j = 0;

    while (j < width / 2)
    {
        Console.Write("*");
        j++;
    }

    Console.WriteLine();

    counter++;



    width += 8;
}*/
