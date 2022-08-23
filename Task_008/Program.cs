//       Задача:
//  Показать четные числа от 1 до N
//    Программа:


string GetVseNub (int nub)
{
    string vseNub = string.Empty;
    for (int i = 1; i <= nub; i++)
    {
        if (i % 2 == 0)
        {
            vseNub += $"{i} ";
        }
    }
    return vseNub;
}


System.Console.Write("введите число для промежутка (1 до N) - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetVseNub(nub));
