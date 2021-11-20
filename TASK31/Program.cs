// 31. Задать массив из 8 элементов и вывести их на экран 

// 1й способ
int[] a = new int[8];
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(1, 100);
    Console.Write(a[i] + " ");
}
Console.WriteLine();

// 2й способ - Через метод
void b(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.Write(arr[i] + " ");
    }
}
b(a, -10, 10);
