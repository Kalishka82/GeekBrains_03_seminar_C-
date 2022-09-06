using System;
// / 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.
Console.Write("Input X Y: ");
string xy = Console.ReadLine(); // 5 7
string[] parts = xy.Split(' ');
int X = int.Parse(parts[0]);
int Y = int.Parse(parts[1]);
if (X > 0 && Y > 0)
    Console.WriteLine("1-ая четверть");
else if (X > 0 && Y < 0)
    Console.WriteLine("4-ая четверть");
else if (X < 0 && Y < 0)
    Console.WriteLine("3-я четверть");
else if (X < 0 && Y > 0)
    Console.WriteLine("2-ая четверть");   
else
    Console.WriteLine("Неправилная точка! Не соответсвует условию задачи");
    