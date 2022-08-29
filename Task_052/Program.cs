//                Задача:
//  В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
//            Программма:



int[,] arrayNumbs = {
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
}; 


double GetNewArrayNumbs (int indexA, int indexB)
{
    double[,] newArrayNubs = new double[10, 10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            
            if (i % 2 == 0 || j % 2 == 0)
            {
                newArrayNubs[i, j] = arrayNumbs[i, j] * arrayNumbs[i, j];
            }
            else
            {
                newArrayNubs[i, j] = arrayNumbs[i, j];
            }
        }
    }
    return newArrayNubs[indexA, indexB];
}

void PrintArrayNumbs ()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write($"{GetNewArrayNumbs(i, j)}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("двумерный масив случайных чисел : ");
PrintArrayNumbs();





