// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] rndArr = new int[10];
for (int i = 0; i < rndArr.Length; i++)
{
    rndArr[i] = new Random().Next(100, 1000);
    Console.Write(rndArr[i] + " ");
}
Console.WriteLine();
int even = 0;
int odd = 0;
for (int i = 0; i < rndArr.Length; i++)
{
    if (rndArr[i] % 2 == 0) even = even + 1;
    else odd = odd + 1;
}
Console.Write("Чётных чисел в массиве " + even);
Console.WriteLine();
Console.Write("Нечётных чисел в массив " + odd);