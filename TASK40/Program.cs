// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] RndArr(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().NextDouble() * 10;
    }
    return Arr;
}

double MaxMin(double[] Arr)
{
    int i = 0;
    double res;
    double max = Arr[i];
    double min = Arr[i];
    for (i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > max) max = Arr[i];
        if (Arr[i] < min) min = Arr[i];
    }
    Console.WriteLine("Максимальное значение = {0:f}", max);
    Console.WriteLine("Минимальное значение = {0:f}", min);
    res = max - min;
    return res;
}

void Print(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine("{0:f}", Arr[i]);
    }
}

double[] Array = new double[10];
RndArr(Array);
Print(Array);
Console.WriteLine("Разница между макс и мин значениями массива = {0:f}", MaxMin(Array));





