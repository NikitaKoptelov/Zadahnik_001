//         Задача:
//  Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//         Программа:


int GetNubArray(int index)
{
    int[] array2 = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array2[i] = new Random().Next(1, 10);
    }
    return array2[index];
}

string GetNub()
{
    int[] arrayProixNub = new int[5];
    for (int i = 0; i < 5; i++)
    {
        arrayProixNub[i] = (GetNubArray(i) * GetNubArray(9 - i));
    }
    string printArray = string.Empty;
    foreach (var item in arrayProixNub)
    {
        printArray += $"{item} ";
    }

    return printArray;
}




System.Console.WriteLine(GetNub());



