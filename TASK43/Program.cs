// // 43. Написать программу преобразования десятичного числа в двоичное

Console.Write("Введите число :");
int digit10 = Convert.ToInt32(Console.ReadLine());
string digit2 = Convert.ToString(digit10, 2);
Console.WriteLine($" В двоичной системе исчесления : {digit2}");