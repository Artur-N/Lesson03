// 28. Подсчитать сумму цифр в числе

int a = new Random().Next(-100000, 100000);
Console.WriteLine(a);

int Sum(int s)
{
    int summa = 0;
    while (s != 0)
    {
        summa = summa + s % 10;
        s = s / 10;
    }
    return summa;
}
Console.WriteLine(Sum(a));