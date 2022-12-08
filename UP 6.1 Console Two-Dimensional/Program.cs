using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_6._1_Console_Two_Dimensional
{
    internal class Program
    {
        static void OutArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int N, M;

            Console.Write("Введите число строк массива: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Были введены неверные данные! Число строк массива должно быть > 0! " +
                    "Введите число строк массива: ");
            }

            Console.Write("Введите число столбцов массива: ");
            while (!int.TryParse(Console.ReadLine(), out M) || M <= 0)
            {
                Console.Write("Были введены неверные данные! Число столбцов массива должно быть > 0! " +
                    "Введите число столбцов массива: ");
            }

            int[,] array = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"Введите значение элемента array[{i}, {j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out array[i, j]))
                    {
                        Console.Write("Были введены неверные данные! " +
                            $"Введите значение элемента array[{i}, {j}]: ");
                    }
                }
            }

            Console.WriteLine("Изначальный двумерный массив: ");
            OutArray(array);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (array[i, j] < 0 && array[i, j] % 3 != 0) array[i, j] *= -1;

            Console.WriteLine("Измененный двумерный массив: ");
            OutArray(array);

        }
    }
}
