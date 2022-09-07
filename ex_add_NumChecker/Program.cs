// string username = Console.ReadLine()!;   // string or null
// if (username == null)
//     ;
// else
//     ;

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
while (true) // зацикливание программы
{
    // main code of the programm:
    Console.Write("Input three-digit number: ");
    int Num = NumChecker(); // вместо обычного ReadLine, сразу проверяем, что число целое

    if (Num >=100 && Num < 1000)
    {
        int digit = (Num / 10) % 10; 
        Console.WriteLine($"Вторая цифра в {Num} -> {digit}");
    }
    else
    {
        Console.WriteLine($"Число {Num} не является трехзначным");
    }
    
    // зацикливание программы:
    Console.WriteLine("Enter, чтобы продолжить / q, чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q') break;    
}
  
int NumChecker()    // метод проверки на ввод числа (функция)
{
    while (true) 
    {
        Console.WriteLine (" //число для продолжения или *q* чтобы выйти");
        string num = Console.ReadLine()!;

        if (num == "q")
        {
            Console.WriteLine($"Вы не ввели число");
            System.Environment.Exit(0); // завершение программы на любом этапе
            return -1;
        }
        else if (int.TryParse(num, out int isItNum))
            return isItNum;
    }
}