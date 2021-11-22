// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

void RndArr(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(0, 100);
        Console.Write(Arr[i] + " ");
    }
}

int FindSumOdd(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + Arr[i];
        }
    }
    return sum;
}

int[] Array = new int[10];
RndArr(Array);
Console.Write("\nСумма чисел стоящих на нечётных позициях = ");
Console.WriteLine(FindSumOdd(Array));

