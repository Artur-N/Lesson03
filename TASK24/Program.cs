// 24. Найти кубы чисел от 1 до N

// Способ №1
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int kub = (int)Math.Pow(i, 3);
    Console.WriteLine($"Число {i} в кубе = {kub}");
}

// Способ №2 через метод и массив
int[] M3(int n)
{
    int[] Arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Arr[i] = (int)Math.Pow(i + 1, 3);
    }
    return Arr;
}
Console.Write("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());
int[] array3 = M3(N);
for (int i = 0; i < array3.Length; i++)
{
    Console.WriteLine($"Число {i + 1} в кубе = {array3[i]}");
}
