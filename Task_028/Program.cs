//       Задача:
//   Подсчитать сумму цифр в числе
//       Программа:


string GetNubSchet (string nubs)
{
    char[] nubSchet = nubs.ToCharArray();
    int schetNub = 0;
    for (int i = 0; i < nubSchet.Length; i++)
    {
        schetNub += (int)Char.GetNumericValue(nubSchet[i]);
    }
    return $"количество введеных цифр - {schetNub}";
}



Console.Write("введите цифры для подсчета - ");
string nubs = Console.ReadLine();
Console.Write(GetNubSchet(nubs));



