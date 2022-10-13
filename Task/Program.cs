string[] MyArray = { "Hello", "18", "Sharp", "10", "Rev", "1001", ":-)" };

string[] ArrayThreeCharacters(string[] array)
{
    string[] NewArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[i] = array[i];
        }

    }
    return NewArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


PrintArray(ArrayThreeCharacters(MyArray));