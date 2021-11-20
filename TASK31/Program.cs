// 31. Задать массив из 8 элементов и вывести их на экран 
// int [] a= new int[8];
double[] arr = new double[10];


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
}
double Cub = 0;
for (int i = 0; i < arr.Length; i++)
{
    
    Cub = Math.Pow(arr[i],3);
    Console.WriteLine(Cub);

     if(Cub%2==0)
     {
         Console.WriteLine( Cub);
     }
}