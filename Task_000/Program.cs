//     Задача:
//  Вывести квадрат числа
//     Программа:


int GetSquareNub (int nub)
{
    int res = nub * nub;
    return res;
}


System.Console.Write("Введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetSquareNub(nub));
