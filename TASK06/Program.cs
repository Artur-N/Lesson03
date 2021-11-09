// Выяснить является ли число чётным
int a;
Console.WriteLine("Введите число:  ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0)
{
    Console.WriteLine((a)+ " Чётное");
}
else
{
    Console.WriteLine((a)+ " Нечётное");
}