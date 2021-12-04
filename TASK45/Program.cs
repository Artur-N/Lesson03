// 45. Показать числа Фибоначчи

int[] Fiboncchi(int[] array)
{
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}


void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arrayF = new int[30];
Fiboncchi(arrayF);
Print(arrayF);
