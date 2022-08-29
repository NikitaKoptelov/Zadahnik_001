//       Задача:
//  Задать номер четверти, показать диапазоны для возможных координат
//      Прогрпамма:


string GetChetXY (int nub)
{
    if (nub == 1)
    {
        return $"в 1 четверти (X > 0 ; Y > 0)";
    }
    else if (nub == 2)
    {
        return $"во 2 четверти (X < 0 ; Y > 0)";
    }
    else if (nub == 3)
    {
        return $"в 3 четверти (X < 0 ; Y < 0)";
    }
    else if (nub == 4)
    {
        return $"в 4 четверти (X > 0 ; Y < 0)";
    }
    else
    {
        return "error";
    }
}


Console.Write("введите значение четверти координат - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.Write(GetChetXY(nub));


