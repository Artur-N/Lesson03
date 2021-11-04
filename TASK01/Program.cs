//По двум заданным числам проверять является ли первое квадратом второго

int a;
int b;
Console.WriteLine("Введите два числа:  ");
string s = Console.ReadLine();
a = Convert.ToInt32(s);
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (a == Math.Pow(b, 2))
{
    Console.WriteLine((a) + " является квадратом " + (b));
}
else
{
    Console.WriteLine((a) + " не является квадратом " + (b));
}