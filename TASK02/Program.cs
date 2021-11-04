// Даны два числа. Показать большее и меньшее число
int a;
int b;
Console.WriteLine("Введите два числа:  ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a>b)
{
   Console.WriteLine("Большее число: "+ (a));
   Console.WriteLine("Меньшее число: "+ (b));
}
else
{
  Console.WriteLine("Большее число: "+ (b));  
  Console.WriteLine("Меньшее число: "+ (a));
}


