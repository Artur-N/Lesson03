// Найти максимальное из трех чисел
int Max(int a, int b, int c)
{
    int max = 0;
    if (a > b) max = a;
    else max = b;
    if (max > c) return max;
    else return c;
}
Console.Write("MAX: ");
Console.WriteLine(Max(31, 55, 14));

Random rnd = new Random().Next(1, 10);
Console.WriteLine(rnd);