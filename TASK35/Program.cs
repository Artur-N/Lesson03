// 35. Определить, присутствует ли в заданном массиве, некоторое число

int[] arr = new int[10];
int i = 0;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.Write("Введите число от 1 до 100: ");
int digit = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < arr.Length; i++)
{
    if (digit == arr[i])
    {
        Console.Write($"Чиcло {digit} присутствует в массиве");
        break;
    }
}
if (i == arr.Length)
{
    Console.Write($"Такого числа нет в массиве");
}

// bool flag = false;
// for (i = 0; i < arr.Length; i++)
// {
//     if (digit == arr[i])
//     {
//         flag = true;
//         break;
//     }
// }
// if (flag == false)
// {
//     Console.Write($"Такого числа нет в массиве");
// }
// else
// {
//     Console.Write($"Чиcло {digit} присутствует в массиве");
// }

