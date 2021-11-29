// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Random rnd = new Random();
double[] RandomArray(double[] Arr)
{

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = rnd.NextDouble() * 10;
    }
    return Arr;
}

double MaxMin(double[] Arr, out double max, out double min)
{
    int i = 0;
    double result;
    max = Arr[i];
    min = Arr[i];
    for (i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > max) max = Arr[i];
        if (Arr[i] < min) min = Arr[i];
    }
    result = max - min;
    return result;
}

void PrintArray(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write("{0:f} | ", Arr[i]);
    }
}

double[] Array = new double[10];
RandomArray(Array);
PrintArray(Array);
double max, min;
double result = MaxMin(Array, out max, out min);
Console.WriteLine();
Console.WriteLine("Максимальное значение = {0:f}", max);
Console.WriteLine("Минимальное значение = {0:f}", min);
Console.WriteLine("Разница между макс и мин значениями массива = {0:f}", result);





