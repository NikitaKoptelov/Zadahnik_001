//          Задача :
//   Показать последнюю цифру трёхзначного числа
//         Программа :

int GetLastNub ( int nub)
{
    int res = nub % 10;
    return res;
}


System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("послядняя цифра числа - ");
System.Console.WriteLine(GetLastNub(nub));

