using System;

namespace Task50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры массива");
            var m = Convert.ToInt32(Console.ReadLine());
            var n = Convert.ToInt32(Console.ReadLine());
            var array = new int[m, n];
            CreateArray(array);

            Console.WriteLine("Введите число");
            var a = Convert.ToInt32(Console.ReadLine());

            for (int firstIndex = 0; firstIndex < array.GetLength(0); firstIndex++)
            {
                for (int secondIndex = 0; secondIndex < array.GetLength(1); secondIndex++)
                {
                    if (array[firstIndex, secondIndex] != a) continue;
                    Console.WriteLine($"элемент находится в в данном месте {firstIndex} {secondIndex}");
                    break;

                }
            }

            Console.WriteLine("числа нету");



        }

        private static void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
            }
        }

    }
}
