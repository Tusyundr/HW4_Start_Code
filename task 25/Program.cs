// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int numa, numb, rst;

Console.Write("Введите число A: ");
numa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
numb = Convert.ToInt32(Console.ReadLine());
    rst = numa;
        for (int i = 2; i <= numb; i++)
            {
                rst *= numa;
            }
Console.WriteLine($"{numa}^{numb} = {rst}");

