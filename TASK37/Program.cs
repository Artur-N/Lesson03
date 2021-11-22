// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] A = new int[123];
int s = 0;
for (int i = 0; i < A.Length; i++)
{
    A[i] = new Random().Next(-100, 200);
    Console.Write(A[i] + " ");
}
for (int i = 0; i < A.Length; i++)
{
    if (A[i] > 10 && A[i] < 100) s = s + 1;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов из отрезка 10-99 равно {s}");

