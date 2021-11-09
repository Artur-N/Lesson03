// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите два числа:  ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Большее число: " + (a));
    Console.WriteLine("Меньшее число: " + (b));
}
else
{
    Console.WriteLine("Большее число: " + (b));
    Console.WriteLine("Меньшее число: " + (a));
}


