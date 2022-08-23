//      Задача:
//  Написать программу вычисления произведения чисел от 1 до N
//       Программа:


int GetPowNub (int nub)
{
    int powNub = 1;
    for (int i = 1; i <= nub; i++)
    {
        powNub *= i;
    }
    return powNub;
}



Console.Write("введите N колличество множителей - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.Write("произведение чисел - ");
Console.Write(GetPowNub(nub));

