//          Задача:
//   Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
//         Программа:


int GetNubArray (int index)
{
    int[] nubArray = new int[10];
    for (int i = 0; i < nubArray.Length; i++)
    {
        nubArray[i] = new Random().Next(99, 999);
    }
    return nubArray[index];
}

string GetNub (int n)
{
    int chetNub = 0, nechetNub = 0;
    for (int i = 0; i < 10; i++)
    {
        double serchNub = (GetNubArray(i));
        if (serchNub % 2 == 1)
        {
            nechetNub += 1;
        }
        else
        {
            chetNub += 1;
        }
    }
    return $"колличество не четных - {nechetNub}\n количество четных - {chetNub}";
}


Console.WriteLine("поиск четных и нечетных чисел:");
Console.Write(GetNub(0));





