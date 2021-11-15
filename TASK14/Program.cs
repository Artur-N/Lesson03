// 14. Найти третью цифру числа или сообщить, что её нет

// 1й вариант

int a = new Random().Next(1, 1000000);
Console.WriteLine(a);

if (a > 99)
{
    int third = a % 1000 / 100;
    Console.WriteLine($"Третья цифра числа {a}: " + third);
}
else
{
    Console.WriteLine($"У числа {a} нет третей цифры");
}

// 2й вариант

void Compare3(int n)
{
    if (n >= 100)
    {
        int b = n % 1000 / 100;
        Console.WriteLine($"Третья цифра числа равна {b}");
    }
    else
    {
        Console.WriteLine($"Число меньше трехзначного");
    }
}

Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
Compare3(c);
Console.WriteLine();