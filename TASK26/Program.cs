// 26. Возведите число А в натуральную степень B используя цикл

int A = 2;
int B = 10;
for (int i = 1; i<=B; i++)
{
    Console.WriteLine($"Число {A} в {i}й степени = {Math.Pow(A,i)}");
}
