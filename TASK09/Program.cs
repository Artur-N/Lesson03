// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 & a < 1000)
{
    Console.WriteLine("Последняя цифра: " + a % 10);
}
else
{
    Console.WriteLine("Просили же ТРЁХЗНАЧНОЕ!!!");
}
