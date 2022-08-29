//       Задача:
//   Возведите число А в натуральную степень B используя цикл
//      Программа:


int GetNubArray (int A, int B, int j)
{
    int[] NumbA = new int [B];
    for (int i = 0; i < B; i++)
    {
        NumbA[i] = A;
    }
    return NumbA[j];
}

int GetStep (int A, int B)
{
    int res = 1;
    for (int j = 0; j < B; j++)
    {
        res*=GetNubArray(A, B, j);
    }
    return res;
}

System.Console.Write("введите число А - ");
int A = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите степен Б - ");
int B = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetStep(A, B));



// int GetStep (int A, int B)
// {
//     int res = 1;
//     for (int i = 0; i < B; i++)
//     {
//         res*=A;
//     }
//     return res;
// }

// System.Console.Write("введите число А - ");
// int A = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите степен Б - ");
// int B = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine(GetStep(A, B));

