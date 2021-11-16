// 21. Программа проверяет пятизначное число на палиндромом.

string pol(int a)
{
    string b = Convert.ToString(a);
    string result = $"Число {a} НЕ является палиндромом";
    if (b[0] == b[4] && b[1] == b[3]) result = $"Число {a} является палиндромом";
    return result;
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pol(num));
