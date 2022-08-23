//          Задача :
// По двум заданным числам проверять является ли одно квадратом другого
//         Программа :



string GetPowNub (int nub1, int nub2)
{
    if (nub1 * nub1 == nub2)
    {
        return $"число А - {nub1} является квадратом числа Б - {nub2}";
    }
    else
    {
        return $"число А - {nub1} не является квадратом числа Б - {nub2}";
    }
    
}



Console.Write("введите число А - ");
int nub1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число Б - ");
int nub2 = Convert.ToInt32(Console.ReadLine());
Console.Write(GetPowNub(nub1, nub2));
