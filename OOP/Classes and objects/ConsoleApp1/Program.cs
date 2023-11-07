
ShowArray(PairValuesArray(5));
static int[] PairValuesArray(int n)
{
    int count = n / 2 + 1;
    int[] resArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        resArray[i] = 2 * i;
    }
    return resArray;
}

static void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
