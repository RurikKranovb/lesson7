using System;

namespace Task52
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

            ConsoleWriteArray(array);

            Average(m, n, array);

        }

        private static void ConsoleWriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t  ");
                Console.WriteLine();

            }
        }

        private static void Average(int m, int n, int[,] array)
        {
            int i, j;
            Random rand = new Random();
            for (j = 0; j < n; j++)
            {
                double sum = 0;
                for (i = 0; i < m; i++)
                {
                    sum = sum + array[i, j];
                }

                Console.Write($"{sum / (i)}  ");
            }
        }

        private static void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Convert.ToInt32(new Random().Next(0, 9));
            }
        }
    }
}
