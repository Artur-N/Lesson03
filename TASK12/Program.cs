// 12. Удалить вторую цифру трёхзначного числа

int triple = new Random().Next(100, 1000);
Console.WriteLine(triple);

// 1й вариант
string delete2 = Convert.ToString(triple);
Console.WriteLine($"{delete2[0]}{delete2[2]}");
//Console.WriteLine(delete2[0] + "" + delete2[2]);
//Console.WriteLine("{0}{1}", delete2[0], delete2[2]);

// 2й вариант
int first = triple / 100;
int third = triple % 10;
Console.WriteLine($"{first}{third}");

// 3й вариант
int del2 = triple / 100 * 10 + triple % 10;
Console.WriteLine(del2);

