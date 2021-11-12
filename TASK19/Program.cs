// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Веедите координату Х");
string s = Console.ReadLine();
double x;
x = Convert.ToInt32(s);

Console.WriteLine("Веедите координату Y");
string s1 = Console.ReadLine();
double Y;
Y = Convert.ToInt32(s1);

Console.WriteLine("Четверть N: " + Q(x, Y));

int Q(double x, double y)
{
    if (x > 0 && Y > 0) return 1;
    if (x < 0 && Y > 0) return 2;
    if (x < 0 && Y < 0) return 3;
    if (x > 0 && Y < 0) return 4;
    return -1;
}
