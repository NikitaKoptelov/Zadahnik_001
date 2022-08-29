//          Задача:
//  В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
//      Программа:

string GetNechetNub()
{
    double[] nubArray = new double[20];
    int sumNechetNub = 0;
    double maxNub = 0;
    double minNub = 0;
    for (int i = 0; i < nubArray.Length; i++)
    {
        nubArray[i] = new Random().NextDouble() *10;
        if (maxNub < nubArray[i])
        {
            maxNub = nubArray[i];
        }
        if (minNub > nubArray[i])
        {
            minNub = nubArray[i];
        }
    }
    return $"разница чисел мин. макс. в массиве - {maxNub - minNub}";
}

System.Console.WriteLine(GetNechetNub());

