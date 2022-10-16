// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int arraylenght, arraymax, arraymin;

Console.WriteLine("Введите число элементов массива: ");
arraylenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное допустимое значение элемента массива: ");
arraymax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arraymin  = Convert.ToInt32(Console.ReadLine());

int[] array = { };

array = ArrayGenerator(arraylenght, arraymax, arraymin);


int[] ArrayGenerator(int lenght, int max, int min) 
{
    Console.Write("Создан массив, заполненный случайными числами: [");
    var array = new int[lenght];
    var rnd = new Random();

       for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        {
            if(i < lenght - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        } 
    }
    Console.WriteLine("]");
    return array;
    }
