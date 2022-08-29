//             Задача:
//  Написать программу, которая обменивает элементы первой строки и последней строки
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
    int[,] izmArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i == 0 )
            {
                izmArray[i, j] = array[array.GetLength(0) - 1, j];
            }
            else if (i == array.GetLength(0) - 1)
            {
                izmArray[i, j] = array[0, j];
            }
            else
            {
                izmArray[i, j] = array[i, j];
            }
        }
    }
    return izmArray;
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
int[,] izmArray = GetNewArrayNumbs(fillArray);
Console.WriteLine("измененный массив : ");
Print(izmArray);
