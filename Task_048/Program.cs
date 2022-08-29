//       Задача:
//  Показать двумерный массив размером m×n заполненный целыми числами
//          Программма:


int[,] GetFillArrayNumbers (int columns, int rows)
{
    int[,] fillArrayNumbers = new int[columns, rows];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(0, 50);
        }
    }
    return fillArrayNumbers;
}



void Print (int[,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{fillArrayNumbers[i, j]:d3} ");
        }
        Console.WriteLine();
    }
}


Console.Write("введите количество столбцов двумерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк двумерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] fillArray = GetFillArrayNumbers(columns, rows);
Console.WriteLine();
Console.WriteLine("двумерный масив случайных чисел : ");
Print(fillArray);

