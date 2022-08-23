//          Задача:
//   Определить, присутствует ли в заданном массиве, некоторое число 
//        Программа:


int[] nubArray = {4, 6, 8, 10, 15, 17, 16, 13};

string GetNubArray (int nub)
{
    string serchNub = string.Empty;
    int n = 1;
    for (int i = 0; i < nubArray.Length * n; i++)
    {
        if ((nubArray[i]) == nub)
        {
            serchNub = $"искомое число найдено - {nubArray[i]} позиция - {i}";
            n = 0;
        }
        else
        {
            serchNub = "искомое число не найдено";
        }
    }
    return serchNub;
}

void PrintNubArray ()
{
    for (int i = 0; i < nubArray.Length; i++)
    {
        Console.Write($"{nubArray[i]} ");
    }
    Console.WriteLine();
}

Console.Write("введите искомое число - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.Write(GetNubArray(nub));
Console.WriteLine();
PrintNubArray();

