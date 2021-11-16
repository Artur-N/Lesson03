// 20. Ввести номер четверти, показать диапазоны для возможных координат

string metod(int a)
{
    string result = String.Empty;
    if (a == 1) result = "Диапазон координат: x > 0, y > 0";
    if (a == 2) result = "Диапазон координат: x > 0, y < 0";
    if (a == 3) result = "Диапазон координат: x < 0, y < 0";
    if (a == 4) result = "Диапазон координат: x < 0, y > 0";
    return result;
}

Console.WriteLine("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(metod(a));
