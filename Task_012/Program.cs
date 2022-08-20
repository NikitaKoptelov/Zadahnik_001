//       Задача:
//   Удалить вторую цифру трёхзначного числа
//        Программа:

string GetSecNub (int nub)
{
    int nub1 = nub / 100;
    int nub2 = nub % 10;
    string res = string.Empty;
    res = $"{nub1}" + $"{nub2}";
    return res;
}

System.Console.Write("введите 3х значное число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("удалена вторая цифра числа - ");
System.Console.WriteLine(GetSecNub(nub));


