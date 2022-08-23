//              Задача:
//   Дано число обозначающее день недели. Выяснить является номер дня недели выходным
//         Программа:


string[] NumbWeekArray = {"error", "нет", "нет", "нет", "нет", "нет", "да", "да"};

string GetWeeks (int numb)
{
    return NumbWeekArray[numb];
}

System.Console.Write("Введите номер дня недели - ");
string numbs = Convert.ToString(System.Console.ReadLine());

int numbValue;
int.TryParse(string.Join("", numbs.Where(c => char.IsDigit(c))), out numbValue);

System.Console.WriteLine($"Введенное число - {numbValue}");

if(6 <= numbValue && numbValue <= 7)
{
    System.Console.WriteLine(GetWeeks(numbValue));
}
else if (1 <= numbValue && numbValue <= 5)
{
    System.Console.WriteLine(GetWeeks(numbValue));
}
else
{
    System.Console.WriteLine(GetWeeks(0));
}


// string GetWeek(int numb)
// {
//     string NumbWeek1 = "да";
//     string NumbWeek2 = "нет";
//     if(6 <= numb && numb <= 7)
//     {
//         return NumbWeek1;
//     }
//     else if (1 <= numb && numb <= 5)
//     {
//         return NumbWeek2;
//     }
//     else
//     {
//         return "Ошибка";
//     }
// }

// System.Console.Write("Введите номер дня недели - ");
// int numb = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine(GetWeek(numb));


