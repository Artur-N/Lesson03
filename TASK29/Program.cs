// 29. Написать программу вычисления произведения чисел от 1 до N

uint P(int a)
{
    uint s = 1;
    for (uint i = 1; i <= a; i++)
    {
        s = s * i;
    }
    return s;
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {N} = {P(N)}");
