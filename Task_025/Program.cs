//    Задача:
//  Найти сумму чисел от 1 до А
//    Программа:


int GetSumNub (int nub)
{
    int sumNub = 0;
    for (int i = 1; i <= nub; i++)
    {
        sumNub += i;
    }
    return sumNub;
}

Console.Write("введите колличество чисел для суммирования - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumNub(nub));

