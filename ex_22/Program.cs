// Задача 22: Напишите программу, которая принимает на вход число
//  (N) и выдаёт таблицу квадратов чисел от 1 до N
Console.Write("Input number N: ");
int N = int.Parse(Console.ReadLine()!);
int[] array = new int[N];
for (int i = 1; i <= N; i++)
{
    array[i - 1] = i * i;
    Console.Write(array[i - 1]);
    if (i < N)
        Console.Write(", ");
    // Console.Write(Math.Pow(i, 2));
    // Console.Write(", ");
}