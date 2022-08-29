//         Задача:
//   Написать программу замену элементов массива на противоположные
//         Программма:




int[] array1 = {-4, -8, 8, 2};

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = array1[i] * (-1);
    System.Console.Write($"{array1[i]} ");
    
}



