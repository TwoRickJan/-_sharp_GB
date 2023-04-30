
string[] array1 = new string[] {"1345", "1", "wor", "3215"};
string[] array2 = new string[array1.Length];
SecondArrayWithOnly3CharStr(array1, array2);
Print1DStringArray(array2);

void SecondArrayWithOnly3CharStr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void Print1DStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

