
int[] array = new int[] { -2, 1, -8, 3, 8, -3, 7, 4, -7, 6 };

Console.WriteLine("We have array: ");

int index = 0;
while (index < array.Length)
{
    Console.Write(array[index]);
    index++;
}

Console.WriteLine("\nWhat element you want remove?: ");
int userRemove = Convert.ToInt32(Console.ReadLine());

int countRemove = 0;
index = 0;
int newIndex = 0;

int[] newArray = new int[array.Length];

while (index < array.Length)
{
    if (array[index] == userRemove)
    {
        countRemove++;
    }
    else
    {
        newArray[newIndex] = array[index];
        newIndex++;
    }
    index++;
}

int[] resultArray = new int[newArray.Length - countRemove];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = newArray[i];
}

index = 0;

while (index < resultArray.Length)
{
    Console.Write(resultArray[index]);
    index++;
}

