// Показать числа от -N до N

Console.WriteLine("Введите отрицательное число от -1 до -10: ");
string s = Console.ReadLine();
int a = Convert.ToInt32(s);
Console.WriteLine("Введите положительное число от 0 до 10: ");
s = Console.ReadLine();
int b = Convert.ToInt32(s);

int n = b - a + 1;
int[] A = new int[n];
int i = 0;
while (A[i] < n)
{
    A[i] = a;
    Console.Write(A[i] + " ");
    a++;
    i++;
}