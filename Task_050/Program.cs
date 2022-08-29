//               Задача:
//   В двумерном массиве n×k заменить четные элементы на противоположные
//            Программа:


int[,] GetFillArrayNumbers (int columns, int rows, int n)
{
    int[,] fillArrayNumbers = new int[columns, rows];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(0, n);
        }
    }
    return fillArrayNumbers;
}


int[,] GetNewArrayNumbs (int[,] array)
{
    int[,] newArrayNubs = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (array[i, j] % 2 == 0)
            {
                newArrayNubs[i, j] = array[i, j] * -1;
            }
            else
            {
                newArrayNubs[i, j] = array[i, j];
            }
        }
    }
    return newArrayNubs;
}

void Print (int[,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{fillArrayNumbers[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество столбцов двумерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк двумерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число от 0 до - ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] fillArray = GetFillArrayNumbers(columns, rows, n);
Console.WriteLine();
Console.WriteLine("двумерный масив случайных чисел : ");
Print(fillArray);
Console.WriteLine();
int[,] newArray = GetNewArrayNumbs(fillArray);
Print(newArray);

