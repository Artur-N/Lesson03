// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д

void RndArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write(arr[i] + " ");
    }
}

int[] Para(int[] arr)
{
    int r = 0;
    int[] Arr2 = new int[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++, j++)
    {
        if (j == arr.Length / 2) break;
        r = arr[i] * arr[arr.Length - i - 1];
        Arr2[j] = r;
    }
    return Arr2;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] Array = new int[9];
RndArr(Array);
Para(Array);
Console.WriteLine();
Console.WriteLine("Произведение пар:");
Print(Para(Array));