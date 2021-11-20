// 30. Показать кубы чисел, заканчивающихся на четную цифру

// int[] kub = new int[10];
// for (int i = 0; i < kub.Length; i++)
// {
//     kub[i] = new Random().Next(1, 10);
//     if (kub[i] % 2 == 0)
//     {
//         Console.WriteLine($"{kub[i]} в кубе = {Math.Pow(kub[i], 3)}");
//     }
//     else
//     {
//         Console.WriteLine($"{kub[i]} в кубе - заканчивается на нечётную цифру");
//     }
// }

// Решение через методы

int[] metod3(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write(arr[i] + " ");
        arr[i] = (int)Math.Pow(arr[i], 3);
        // int s = (int)Math.Pow(arr[i], 3);
        // if (s % 2 == 0)
        // {
        //     arr[i] = s;
        // }
    }
    return arr;
}

void print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        Console.Write(arr[i] + " ");
    }
}

int[] even = new int[10];

metod3(even);
Console.WriteLine();
print(even);


