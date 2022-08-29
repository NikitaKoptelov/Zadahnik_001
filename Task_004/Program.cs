//       Задача:
// Найти максимальное из трех чисел
//     Программа:

string GetMaxNub (int nubA, int nubB, int nubC)
{
    int max = nubA;
    if (max < nubB)
    {
        max = nubB;
        if (max < nubC)
        {
            max = nubC;
        }
    }
    return $"число {max} больше";
}


System.Console.Write("введите число А - ");
int nubA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("введите число Б - ");
int nubB = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("введите число C - ");
int nubC = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetMaxNub(nubA, nubB, nubC));
