// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0) Console.WriteLine($"Число {a} кратно 7 и 23");
else { Console.WriteLine($"Число {a} не кратно 7 и 23"); }

// 2й вариант

// void Capacity(int a, int b, int c)
// {
//     int change = -1;
//     if ((a % b == 0) && (a % c == 0)) change = 1;
//     switch (change)
//     {
//         case 1:
//             Console.WriteLine($"Число {a} кратно и {b}, и {c}");
//             break;
//         default:
//             Console.WriteLine($"Число {a} не кратно {b} и {c}, введите новое");
//             break;
//     }
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 7;
// int c = 23;
// Capacity(a, b, c);
