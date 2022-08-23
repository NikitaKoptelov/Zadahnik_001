//    Задача:
//  Найти кубы чисел от 1 до N
//     Программа:


// int GetKub (int i)
// {
    
//     int numb = i * i * i;
//     return numb;
// }


// string GetNumbers (int nub)
// {
//     int j = 1;
//     string Numbers = string.Empty;
//     int[] NumbersArray = new int[nub];
//     while(j <= nub)
//     {
//     NumbersArray[j - 1] = GetKub(j);
//     j++;
//     }
//     Numbers = string.Join(' ', NumbersArray);
//     return Numbers;
// }


// System.Console.Write("Введите количество кубов чисел - ");
// int nub = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine(GetNumbers(nub));

string GetNumbersKub (double nub)
{
    string otvet = string.Empty;
    for (int n = 0; n <= nub; n++)
    {
        double nubKub = Math.Cbrt(n);
        double nubKub1 = Math.Round(nubKub, 0);
        if (nubKub - nubKub1 == 0)
        {
            otvet += $"число {n} является кубом числа {Math.Cbrt(n)}\n";
        }
    }
    return otvet;
}


Console.Write("введите количество чисел для поиска - ");
double nub = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(GetNumbersKub(nub));


