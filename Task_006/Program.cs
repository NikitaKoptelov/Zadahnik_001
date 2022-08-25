//           Задача:
//  Выяснить является ли число чётным
//          Программа:


string GetShetNub (int nub)
{
    if (nub % 2 == 0)
    {
        return "число четное";
    }
    else
    {
        return "число не четное";
    }
}


System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetShetNub(nub));
