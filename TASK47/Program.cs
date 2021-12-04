// 47. Написать программу копирования массива

Random rnd = new Random();
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CopyArray(int[] array1, int[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
return array2;
}

int[] array1 = new int[10];
int[] array2 = new int[10];
FillArray(array1);
Print(array1);
System.Console.WriteLine();
CopyArray(array1, array2);
Print(array2);
