//        Задача:
// По заданному номеру дня недели вывести его название
//      Программа:

string GetWeeks (int nubWeeks)
{
    string[] Weeks = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    return Weeks[nubWeeks-1];
}


System.Console.Write("Введите день недели - ");
int nubWeeks = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetWeeks(nubWeeks));
