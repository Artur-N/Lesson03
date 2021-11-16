// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

Console.WriteLine("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine()); // new Random().Next(1, 8);

if (a == 6 || a == 7) Console.WriteLine("Выходной!");
else if (a < 6) {Console.WriteLine("Рабочий день");}
else {Console.WriteLine("Нет такого дня недели");}
