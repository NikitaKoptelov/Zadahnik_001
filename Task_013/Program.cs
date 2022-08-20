//         Задача:
//   Выяснить, кратно ли число заданному, если нет, вывести остаток.
//      Программа:


string GetMultipNub (int nub)
{
    int nub1 = new Random().Next(1, 10);
    if (nub1 % nub != 0)
    {
        double ost = (Convert.ToDouble(nub1)) / (Convert.ToDouble(nub));
        return $"число не кратное {nub1} - {ost}";
    }
    else
    {
        return $"число кратное {nub1}";
    }
}


System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetMultipNub(nub));

