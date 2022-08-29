//           Задача:
//   Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива 
//          Программа:


int GetArrayNub (int index)
{
    int[] arrayNub = new int[12];
    for (int i = 0; i < 12; i++)
    {
        arrayNub[i] = new Random().Next(0, 9);
    }
    return arrayNub[index];
}

string GetSumNubPol ()
{
    int otvet = 0;
    for (int i = 0; i < 12; i++)
    {
        if (GetArrayNub(i) > 0)
        {
            otvet += GetArrayNub(i);
        }
    }
    return $"{otvet} ";
}

string GetSumNubOtr ()
{
    int otvet = 0;
    for (int i = 0; i < 12; i++)
    {
        if (GetArrayNub(i) < 0)
        {
            otvet += GetArrayNub(i);
        }
    }
    return $"{otvet} ";
}

void PrintArrayNub ()
{
    Console.Write("[");
    for (int i = 0; i < 12; i++)
    {
        Console.Write(GetArrayNub(i));
        Console.Write(" ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("массив из 12 элементов : ");
PrintArrayNub();
Console.Write("сумма положительных чисел - ");
Console.Write(GetSumNubPol());
Console.WriteLine();
Console.Write("сумма отрицательных чисел - ");
Console.Write(GetSumNubOtr());


