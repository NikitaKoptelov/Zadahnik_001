//         Задача:
//   Найти расстояние между точками в пространстве 2D/3D
//       Программа:


double GetCoords (string coords, int index)
{
    string[] array = new string[3];
    array = coords.Split(",");      

    return Convert.ToDouble(array[index]);
}


System.Console.Write("Введите 3х мерные координаты точки А через (,) - ");
string coordsA = Convert.ToString (System.Console.ReadLine());

System.Console.Write("Введите 3х мерные координаты точки Б через (,) - ");
string coordsB = Convert.ToString (System.Console.ReadLine());

System.Console.Write("Длинна отрезка АБ - ");
System.Console.WriteLine(GetLenghAB());


double GetLenghAB ()
{
    double lengAB = Math.Sqrt(Math.Pow((GetCoords(coordsB, 0) - 
    (GetCoords(coordsA, 0))), 2) + Math.Pow((GetCoords(coordsB, 1) - 
    (GetCoords(coordsA, 1))), 2) + Math.Pow((GetCoords(coordsB, 2) - 
    GetCoords(coordsA, 2)), 2));
    return lengAB;    
}



