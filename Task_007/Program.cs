//      Задача:
//  Показать числа от -N до N
//       Программа:


string GetVseNub (int nub)
{
    string vseNub = string.Empty;
    for (int i = nub * (-1); i <= nub; i++)
    {
        vseNub += $"{i} ";
    }
    return vseNub;
}


System.Console.Write("введите число для промежутка (-N до N) - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetVseNub(nub));

