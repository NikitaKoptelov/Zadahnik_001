//        Задача:
//  Сколько есть программ, которые преобразуют число 2 в число 17?
//  У исполнителя есть 3 команды:
//      Прибавить 1,
//      Прибавить 2,
//      Умножить на 4.
//      Программа:

int GetNumbersProg(int numb)
{
    int numbProg1 = 0, numbProg2 = 0, res = 0;
    if (numb == 2)
    {
        return 1;
    }
    else if (numb > 1)
    {
        numbProg1 = GetNumbersProg(numb - 1);
        numbProg2 = GetNumbersProg(numb - 2);
        if (numb % 4 == 0)
        {
            res = GetNumbersProg(numb / 4) + numbProg1 + numbProg2;
            return res;
        }
        else
        {
            res = numbProg1 + numbProg2;
            return res;
        }
    }
    else
    {
        return res;
    }
}


Console.WriteLine(GetNumbersProg(17));


