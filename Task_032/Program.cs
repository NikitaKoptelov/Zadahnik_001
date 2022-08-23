//          Задача:
//   Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
//        Программа:


int GetArrayNub (int index)
{
    int[] arrayNub = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arrayNub[i] = new Random().Next(0,2);
    }
    return arrayNub[index];
}

void PrintArrayNub ()
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        Console.Write(GetArrayNub(i));
        Console.Write(" ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("массив из 8 элементов : ");
PrintArrayNub();



