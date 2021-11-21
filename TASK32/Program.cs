// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 1й способ
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

// 2й способ - через метод 
void Arr8(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i] + " ");
    }
}
Arr8(array);