//           Задача:
//  Выяснить является ли число чётным
//          Программа:


string GetShetNub (int nub)
{
    if (nub % 2 == 1)
    {
        return "число не четное";
    }
    else
    {
        return "число четное";
    }
}


System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetShetNub(nub));
