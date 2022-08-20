//          Задача:
//  Показать вторую цифру трёхзначного числа
//        Программа:

int GetSecNub (int nub)
{
    int res = (nub % 100) / 10;
    return res;
}

System.Console.Write("введите 3х значное число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("вторая цифра числа - ");
System.Console.WriteLine(GetSecNub(nub));