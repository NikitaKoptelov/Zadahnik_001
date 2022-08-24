//            Задача:
//  Найти сумму чисел одномерного массива стоящих на нечетной позиции
//         Программа:


int GetArrayNub (int index)
{
    int[] arrayNub = new int[200];
    for (int i = 0; i < 200; i++)
    {
        arrayNub[i] = new Random().Next(0, 200);
    }
    return arrayNub[index];
}

int GetSumNub ()
{
    int countSumNub = 0;
    for (int i = 0; i < 200; i++)
    {
        if (i % 2 == 1)
        {
            countSumNub += GetArrayNub(i);
        }
    }
    return countSumNub;
}


Console.Write("сумма чисел на нечетной позиции - ");
Console.WriteLine(GetSumNub());


