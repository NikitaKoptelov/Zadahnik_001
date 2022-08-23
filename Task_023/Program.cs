//       Задача:
//   Показать таблицу квадратов чисел от 1 до N
//     Программа:


int GetKub (int i)
{
    
    int numb = i * i;
    return numb;
}


string GetNumbers (int nub)
{
    int j = 1;
    string Numbers = string.Empty;
    int[] NumbersArray = new int[nub];
    while(j <= nub)
    {
    NumbersArray[j - 1] = GetKub(j);
    j++;
    }
    Numbers = string.Join(' ', NumbersArray);
    return Numbers;
}


System.Console.Write("Введите количество квадратов чисел - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetNumbers(nub));




