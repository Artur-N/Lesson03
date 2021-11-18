// 27. Определить количество цифр в числе

ulong CountDigit(ulong n)
{
    ulong k;
    for (k = 0; n != 0; k++)
    {
        n = n / 10;
    }
    return k;
}
Console.Write("Введите число: ");
ulong x = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine($"Число {x} состоит из {CountDigit(x)} цифр");
