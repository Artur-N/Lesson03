// 30. Показать кубы чисел, заканчивающихся на четную цифру

int[] metod3(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)Math.Pow(arr[i], 3);
        if (arr[i] % 2 == 0)
        {
            arr2[j] = arr[i];
            j++;
        }
    }
    return arr2;
}

int[] array = new int[10];
Random rnd = new Random();
for (int j = 0; j < array.Length; j++)
{
    array[j] = rnd.Next(1, 10);
    Console.Write(array[j] + " ");
}
Console.WriteLine();
int[] even = metod3(array);
for (int i = 0; i < even.Length; i++)
{
    Console.Write(even[i] + " ");
}


