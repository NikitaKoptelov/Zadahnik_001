//       Задача:
//  Показать кубы чисел, заканчивающихся на четную цифру
//       Программа:


string GetKubNub (int nub)
{
    string kubNub = string.Empty;
    for (int i = 1; i <= nub; i++)
    {
        int nub1 = (i * i * i) % 10;
        if(nub1 % 2 != 1)
        {
            kubNub += $"{(i * i * i)}  ";
        }
    }
    return kubNub;
}


Console.Write("введите N чисел для нахождения чисел в кубе с четной цифрой - ");
int nub = Convert.ToInt32(Console.ReadLine());
Console.Write(GetKubNub(nub));

