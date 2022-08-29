//        Задача:
//   Написать программу преобразования десятичного числа в двоичное
//         Программа:


string GetNubTwo (int nub)
{
    string bitNub = string.Empty;
    int nubTwo = 0, nub1 = nub, nub2 = nub;
    do
    {
        bitNub += " ";
        nubTwo = nub1 / 2;
        nub2 = nubTwo;
        if (nub2 * 2 == nub1)
        {
            bitNub += "0";
        }
        else
        {
            bitNub += "1";
        }
        nub1 = nub2;
        
        
    } while (nub1 > 0);
    char[] bitNub1 = bitNub.ToCharArray();
    Array.Reverse(bitNub1);
    bitNub = new string(bitNub1);
    return bitNub;
}






Console.Write("введите чесло для преобразования - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetNubTwo(nub));
