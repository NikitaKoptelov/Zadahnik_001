//          Задача:
//  В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
//         Программа:


int GetNubArray (int index)
{
    int[] nubArray = new int[123];
    for (int i = 0; i < 123; i++)
    {
        nubArray[i] = i;
    }
    return nubArray[index];
}

int GetNub ()
{
    int countNub = 0;
    for (int i = 0; i < 123; i++)
    {
        
        if (GetNubArray(i) >= 10 && GetNubArray(i) <= 99)
        {
            countNub += 1;
        }
    }
    return countNub;
}


Console.Write("количество найденых элементов - ");
Console.Write(GetNub());


