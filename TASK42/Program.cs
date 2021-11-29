// 42. Определить сколько чисел больше 0 введено с клавиатуры

int UpZero(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) count++;
    }
    return count;
}

int[] CreateArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

int[] Array = new int[5];
CreateArray(Array);
Console.WriteLine($"Чисел больше 0 введено - {UpZero(Array)} шт");
