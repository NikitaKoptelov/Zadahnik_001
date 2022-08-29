//     Задача:
//  Написать программу копирования массива
//      Программа:


int GetOldArray (int index)
{
    int[] oldArray = {45, 1, 21, 15, 74, 65, 23, 32};
    return oldArray[index];
}


int GetNewArray (int index)
{
    int[] newArray = new int[8];
    for (int i = 0; i < 8; i++)
    {
        newArray[i] = GetOldArray(i);
    }
    return newArray[index];
}



void PrintOldArray ()
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{GetOldArray(i)} ");
    }
}

void PrintNewArray ()
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{GetNewArray(i)} ");
    }
}


Console.Write("старый массив - ");
PrintOldArray();
Console.WriteLine();
Console.Write("копировать массив: нажмите ввод.");
Console.ReadLine();
Console.Write("новый массив - ");
PrintNewArray();
