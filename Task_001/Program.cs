//                   Задача:
// По двум заданным числам проверять является ли первое квадратом второго
//          Программа :


string GetSquareNub (int nubA, int nubB)
{
    if ((nubA*nubA) == nubB)
    {
        return "А - является квадратом - Б";
    }
    else
    {
        return "Не является";
    }
}


System.Console.Write("Введите число А - ");
int nubA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число Б - ");
int nubB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetSquareNub(nubA, nubB));
