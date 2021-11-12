// 33. Задать массив из 12 элементов, заполненных 
// числами из [-9,9]. Найти сумму положительных
// и отрицательных элементов массива

int[] A = new int[12];
int s = 0;
int s2 = 0;
for (int i = 0; i < A.Length; i++)
{
    A[i] = new Random().Next(-9, 10);
    Console.Write(A[i] + " ");
    if (A[i] > 0)
    {
        s = s + A[i];
    }
    else
    {
        s2 = s2 + A[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = " + s);
Console.WriteLine($"Сумма отрицательных чисел = " + s2);
