//         Задача:
//   Дано число. Проверить кратно ли оно 7 и 23
//        Программа:

string GetKratNub (int nub)
{
    string kratNub = string.Empty;
    if (nub % 7 == 0) 
    {
        kratNub += "число кратно 7, ";
    }
    else
    {
        kratNub += "не кратно 7, ";
    }
    if (nub % 23 == 0)
    {
        kratNub += "число кратно 23, ";
    }
    else
    {
        kratNub += "не кратно 23, ";
    }
    return kratNub;
}


System.Console.Write("введите число - ");
int nub = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetKratNub(nub));

