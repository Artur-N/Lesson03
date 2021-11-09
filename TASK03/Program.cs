// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите число дня недели:  ");
int a = Convert.ToInt32(Console.ReadLine());

// if (a==1) {Console.WriteLine ("Понедельник");}
// else if (a==2) {Console.WriteLine ("Вторник");}
// else if (a==3) {Console.WriteLine ("Среда");}
// else if (a==4) {Console.WriteLine ("Четверг");}
// else if (a==5) {Console.WriteLine ("Пятница");}
// else if (a==6) {Console.WriteLine ("Суббота");}
// else if (a==7) {Console.WriteLine ("Воскресенье");}
// else {Console.WriteLine ("Нет такого дня недели");}

string[] week = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
int i;
if (a > 0 & a < 8)
{
    i = a - 1;
    Console.WriteLine(week[i]);
}
else 
{
    Console.WriteLine ("Нет такого дня недели");
}

// switch (s)
// {
//     case "1":
//     Console.WriteLine ("Понедельник");
//     break;
//     ...
//     default:
//     Console.WriteLine ("Нет такого дня недели");
//     break;
// }

// string[] days = new string[8];

// days[1] = "Понедельник";
// days[2] = "Вторник";
// days[3] = "Среда";
// days[4] = "Четверг";
// days[5] = "Пятница";
// days[6] = "Суббота";
// days[7] = "Воскресенье";
// days[0] = "Нет такого дня недели";
// int day = Convert.ToInt32(s);
// Console.WriteLine(days[day]);