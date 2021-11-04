// Найти максимальное из трех чисел
int[] array = new int[3];
Random rnd = new Random();
for (int i = 0; i < 3; i++)
{
    array[i] = rnd.Next(1, 101);
}
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(array[i] + " ");
}

int max = 0;
for (int i = 0; i < 3; i++)
{
    if (array[i]>max) max = array[i];
}
    
Console.Write("MAX: "+ (max));
