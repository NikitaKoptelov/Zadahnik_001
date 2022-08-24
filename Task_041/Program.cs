//        Задача:
//  Выяснить являются ли три числа сторонами треугольника 
//      Программма:


string GetNubForm (int nubA, int nubB, int nubC)
{
    string nubForm = string.Empty;
    if ((Math.Pow(nubC, 2)) < ((Math.Pow(nubA, 2)) + (Math.Pow(nubB, 2))))
    {
        nubForm = "треугольник остроугольный";
    }
    else if ((Math.Pow(nubC, 2)) == ((Math.Pow(nubA, 2)) + (Math.Pow(nubB, 2))))
    {
        nubForm = "треугольник прямоугольный";
    }
    else if ((Math.Pow(nubC, 2)) > ((Math.Pow(nubA, 2)) + (Math.Pow(nubB, 2))))
    {
        nubForm = "треугольник тупоугольный";
    }
    return nubForm;
}


Console.Write("введите число для А - ");
int nubA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число для B - ");
int nubB = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число для C - ");
int nubC = Convert.ToInt32(Console.ReadLine());
Console.Write(GetNubForm(nubA, nubB, nubC));

