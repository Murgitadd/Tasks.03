int[] array = { 2, 3, 1, 6, 4, 7, 5 };
int length = array.Length;

for (int i = 0; i < length; i++)
{
    for (int j = i + 1; j < length; j++)
    {
        if (array[i] < array[j])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

for (int i = 0; i < length; i++)
{
    Console.WriteLine(array[i]);
}
