//         Задача :
//  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
//        Программа :


string GetChetXY (int nubX, int nubY)
{
    if (nubX > 0 && nubY > 0)
    {
        return $"введенные координаты (x, y) - ({nubX}, {nubY}) лежат в 1 четверти";
    }
    else if (nubX < 0 && nubY > 0)
    {
        return $"введенные координаты (x, y) - ({nubX}, {nubY}) лежат во 2 четверти";
    }
    else if (nubX < 0 && nubY < 0)
    {
        return $"введенные координаты (x, y) - ({nubX}, {nubY}) лежат в 3 четверти";
    }
    else if (nubX > 0 && nubY < 0)
    {
        return $"введенные координаты (x, y) - ({nubX}, {nubY}) лежат в 4 четверти";
    }
    else
    {
        return "error";
    }
}


Console.Write("введите значение координаты Х - ");
int nubX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение координаты Y - ");
int nubY = Convert.ToInt32(Console.ReadLine());
Console.Write(GetChetXY(nubX, nubY));
