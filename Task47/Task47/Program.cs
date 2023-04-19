using System;

namespace Task47
{
    class Program
    {
        static void Main(string[] args)
        {

            const int m = 3, n = 4;

            var random = new Random();

            double[,] items = new double[m, n];

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    var item = random.Next(-100, 100);
                    items[j, i] = Math.Round(item + random.NextDouble(),2);
                    Console.Write($"{items[j,i]:F}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
