// 23. Показать таблицу квадратов чисел от 1 до N

int[] pow2(int n)
{
    int[] tabl = new int[n];
    for (int i = 0; i < n; i++)
    {
        tabl[i] = (int)Math.Pow(i+1, 3);
    }
    return tabl;
}

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = pow2(N);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Квадраты {arr[i]}");
}