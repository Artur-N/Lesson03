// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число: ");
double a = Convert.ToInt32(Console.ReadLine());
double b;
if (a >= 100 & a < 1000)
{
    b=((a%100)-(a%10))/10;
    
    Console.WriteLine("Последняя цифра: " + b);
}
else
{
    Console.WriteLine("Просили же ТРЁХЗНАЧНОЕ!!!");
}
