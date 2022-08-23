//     Задача:
//  Определить количество цифр в числе
//     Программа :


string GetNubSchet (string nubs)
{
    char[] nubSchet = nubs.ToCharArray();
    int schetNub = 0;
    for (int i = 0; i < nubSchet.Length; i++)
    {
        schetNub +=1;
    }
    return $"количество введеных символов - {schetNub}";
}



Console.Write("введите символы для подсчета - ");
string nubs = Console.ReadLine();
Console.Write(GetNubSchet(nubs));


