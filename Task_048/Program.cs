//       Задача:
//  Показать двумерный массив размером m×n заполненный целыми числами
//          Программма:


int GetArrayNumbs (int indsexA, int indexB)
{
    int[,] arrayNubs = new int[10, 10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            arrayNubs[i, j] = new Random().Next(0, 50);
        }
    }
    return arrayNubs[indsexA, indexB];
}



void PrintArrayNumbs ()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write($"{GetArrayNumbs(i, j)}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("двумерный масив случайных чисел : ");
PrintArrayNumbs();

