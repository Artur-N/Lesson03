// 27. Определить количество цифр в числе

long CountDigit(long n)
{
    long k;
    for (k = 0; n != 0; k++)
    {
        n = n / 10;
    }
    return k;
}
Console.Write("Введите число: ");
long x = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Число {x} состоит из {CountDigit(x)} цифр");
