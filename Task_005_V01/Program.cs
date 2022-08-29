//         Задача:
//  Написать программу вычисления значения функции y = f(a)
//         Программа:



double GetFunkcNub (double nub, string funkc)
{
    double step = 1;
    if (funkc == "pow")
    {
        System.Console.Write("введите степень числа -");
        step = Convert.ToDouble(System.Console.ReadLine());
    }
    var DiktFunkcNub = new Dictionary<string, double>
    {
        ["acos"] = Math.Acos(nub),
        ["asin"] = Math.Asin(nub),
        ["atan"] = Math.Atan(nub),
        ["ceiling"] = Math.Ceiling(nub),
        ["cos"] = Math.Cos(nub),
        ["cosh"] = Math.Cosh(nub),
        ["exp"] = Math.Exp(nub),
        ["abs"] = Math.Abs(nub),
        ["floor"] = Math.Floor(nub),
        ["log"] = Math.Log(nub),
        ["log10"] = Math.Log10(nub),
        ["pow"] = Math.Pow(nub, step),
        ["sin"] = Math.Sin(nub),
        ["sinh"] = Math.Sinh(nub),
        ["sqrt"] = Math.Sqrt(nub),
        ["tan"] = Math.Tan(nub),
        ["tanh"] = Math.Tanh(nub),
        ["cos"] = Math.Cos(nub),
        ["cbrt"] = Math.Cbrt(nub),
        ["abs"] = Math.Abs(nub)
    };

    return DiktFunkcNub[funkc];
}



System.Console.Write("введите число - ");
double nub = Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("введите функцию числа - ");
string funkc = System.Console.ReadLine();
System.Console.WriteLine(GetFunkcNub(nub, funkc));

