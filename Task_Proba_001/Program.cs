// спиральное заполнение двумерного масива



int n = 20, count = 0;
int[,] arrayNumbers = new int[n, n];
int schetNubers = 0;
int storona1 = 0, storona2 = 0, storona3 = 0, storona4 = 0;

int GetArrayNumbers(int indexA, int indexB)
{
    for (int i = 0; i < n; i++)
    {
        n--;
        for (storona1 = storona4; storona1 < n; storona1++)
        {
            arrayNumbers[storona4, storona1] = schetNubers;
            schetNubers++;
        }

        for (storona2 = storona4; storona2 < storona1; storona2++)
        {
            arrayNumbers[storona2, storona1] = schetNubers;
            schetNubers++;
        }
        
        for (storona3 = storona2; storona3 > count; storona3--)
        {
            arrayNumbers[storona2, storona3] = schetNubers;
            schetNubers++;
        }
        
        for (storona4 = storona1; storona4 > count; storona4--)
        {
            arrayNumbers[storona4, storona3] = schetNubers;
            schetNubers++;
        }
        count++;
        storona4++;
        storona3++;
        storona2++;
        storona1++;
    }
    return arrayNumbers[indexA, indexB];
}

void PrintArrayNumbers ()
{
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            Console.Write($"{GetArrayNumbers(i, j):d3} ");
        }
        Console.WriteLine();
    }
}


PrintArrayNumbers();


