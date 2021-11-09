//По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите два числа:  ");

int a = Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());

if (a == Math.Pow(b, 2))
{
    Console.WriteLine((a) + " является квадратом " + (b));
}
else
{
    Console.WriteLine((a) + " не является квадратом " + (b));
}