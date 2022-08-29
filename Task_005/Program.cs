//         Задача:
//  Написать программу вычисления значения функции y = f(a)
//         Программа:


using System.Data;



System.Console.Write("введите вырожение с функцией - ");
string s = System.Console.ReadLine();
double rez = Convert.ToDouble(new DataTable().Compute(s, ""));
Console.WriteLine(rez);
