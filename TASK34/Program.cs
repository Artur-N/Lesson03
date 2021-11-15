// 34. Написать программу замену элементов массива на противоположные

int[] Array = new int[10];
int i = 0;
for (i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-10, 10);
    Console.Write(Array[i] + " ");
    
}
Console.WriteLine();
for (i = 0; i < Array.Length; i++)
{
    Array[i] = Array[i] * -1;
    Console.Write(Array[i] + " ");
}
