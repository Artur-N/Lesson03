// 17. По двум заданным числам проверять является ли одно квадратом другого

void metod(int x, int y)
{
    if (x*x==y) Console.WriteLine($"Число {y} является квадратом числа {x}");
    else if (y*y==x) Console.WriteLine($"Число {x} является квадратом числа {y}");
    else Console.WriteLine("Одно число не является квадратом другого");
}

Console.WriteLine("Введите 2 числа: " );
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
 
metod(a, b);