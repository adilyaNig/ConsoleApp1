using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            Console.WriteLine("\nВведите элементы матрицы построчно:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int minSum = int.MaxValue;
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                }
            }
            Console.WriteLine($"\nНаименьшая сумма строк: {minSum}");
            Console.ReadKey();
        }
    }
}
