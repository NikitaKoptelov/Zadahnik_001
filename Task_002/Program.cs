//          Задача :
// Даны два числа. Показать большее и меньшее число
//      Программа :


string GetComparNub (int nubA, int nubB)
{
    if (nubA > nubB)
    {
        return $"число А - {nubA} больше числа Б - {nubB}";
    }
    else
    {
        return $"число Б - {nubB} больше числа А - {nubA}";
    }
}

System.Console.Write("введите число А - ");
int nubA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("введите число Б - ");
int nubB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetComparNub(nubA, nubB));
