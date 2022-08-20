//           Задача:
//  Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//         Программа:


string GetMaxNub ()
{
    int nub = new Random().Next(10, 99);
    int nub1 = nub / 10;
    int nub2 = nub % 10;
    if (nub1 > nub2) 
    {
        return $"максимальная цифра {nub1} числа {nub}";
    }
    else
    {
        return $"максимальная цифра {nub2} числа {nub}";
    }
    
}


System.Console.WriteLine(GetMaxNub());
