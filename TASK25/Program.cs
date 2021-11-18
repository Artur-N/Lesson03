// Найти сумму чисел от 1 до А

int metod(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum = i + sum;
    }
    return sum;
}
    Console.Write("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел от 1 до {A} = {metod(A)}");
