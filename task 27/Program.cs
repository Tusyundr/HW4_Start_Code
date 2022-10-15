// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num, rst;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
    rst = 0;
    while (num != 0)
    {
        rst += num % 10;
        num /= 10;
    }

Console.WriteLine($"Сумма цифр в числе {num} = {rst}");