using System;
// Задача 20: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
Console.Write("Input X1 Y1: ");
string xy = Console.ReadLine()!; // 5 7
string[] parts = xy.Split(' ');
int X1 = int.Parse(parts[0]);
int Y1 = int.Parse(parts[1]);

Console.Write("Input X2 Y2: ");
xy = Console.ReadLine()!; // 5 7
parts = xy.Split(' ');
int X2 = int.Parse(parts[0]);
int Y2 = int.Parse(parts[1]);

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.WriteLine($"Расстояние между 2мя точками равно {distance:F2} единиц.");