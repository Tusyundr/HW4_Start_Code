// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int num; 

Console.WriteLine("Будет создан массив длиной N");
Console.Write("Введите N - число элементов массива: ");

num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
         for (int i = 0; i < num; i++)
            {
                array[i] = new Random().Next(num+1);
            }
            Console.WriteLine($"[{String.Join(", ", array)}]");;

