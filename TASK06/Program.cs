// Выяснить является ли число чётным

Console.WriteLine("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine((a)+ " Чётное");
}
else
{
    Console.WriteLine((a)+ " Нечётное");
}