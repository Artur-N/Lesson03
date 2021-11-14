// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a = new Random().Next(1, 100);
Console.WriteLine("Заданное число: " + a);
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a%b==0) 
{
    Console.WriteLine($"Число {b} кратно числу {a}");
}
else 
{
    Console.WriteLine($"Число {b} НЕ кратно числу {a}, остаток {a%b}");
}

