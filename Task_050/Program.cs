//               Задача:
//   В двумерном массиве n×k заменить четные элементы на противоположные
//            Программа:


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
            
            if (arrayNumbs[i, j] % 2 == 0)
            {
                newArrayNubs[i, j] = arrayNumbs[i, j] * -1;
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





