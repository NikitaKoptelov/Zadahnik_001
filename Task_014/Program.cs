//         Задача:
//   Найти третью цифру числа или сообщить, что её нет
//         Программа :


string GetThreeNub (int nub)
{
    if ((nub % 1000) / 100 > 0)
    {
        return $"третья цифра числа - {(nub % 1000) / 100}";
    }
    else
    {
        return "третьей цифры числа нет";
    }
}

System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetThreeNub(nub));
