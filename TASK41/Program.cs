// 41. Выяснить являются ли три числа сторонами треугольника

string ThreeNumbers(int a, int b, int c)
{
    string result;
    if (a + b > c && b + c > a && a + c > b) result = "Являются";
    else result = "Не являются";
    return result;
}
int a = 5;
int b = 3;
int c = 4;
Console.WriteLine(ThreeNumbers(a, b, c));