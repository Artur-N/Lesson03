// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 1й вариант:
int a = new Random().Next(10, 100);
int b = a%10;
int c = (a-b)/10;
if (b > c) Console.Write($"Наибольшая цифра числа {a}: {b}");
else {Console.Write($"Наибольшая цифра числа {a}: {c}");}

// 2й вариант:
Console.WriteLine();

string d = Convert.ToString(a);
if (d[0]>d[1]) Console.Write($"Наибольшая цифра числа {a}: {d[0]}");
else {Console.Write($"Наибольшая цифра числа {a}: {d[1]}" );}


