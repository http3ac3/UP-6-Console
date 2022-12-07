using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_6._4_Console
{
    internal class Program
    {
        static void PrintOneDArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите число N -> ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Введено недопустимое значение!\nВведите N (целое, больше 0) -> ");
            }
            int[][] arr = new int[N][];

            for (int i = 0; i < N; i++)
            {
                arr[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Введите arr[{i}][{j}] -> ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i][j]))
                    {
                        Console.Write($"Введены недопустимые данные! Число должно быть целым!\nВведите arr[{i}][{j}] -> ");
                    }
                }
            }

            Console.WriteLine("Изначальный массив: ");
            for (int i = 0; i < N; i++)
            {
                PrintOneDArray(arr[i]);
            }

            int vecN;
            Console.Write("Введите количество элементов вектора -> ");
            while (!int.TryParse(Console.ReadLine(),out vecN))
            {
                Console.Write($"Введены недопустимые данные! Число должно быть целым и больше 0!" +
                    $"\nВведите количество элементов вектора -> ");
            }

            int[] vec = new int[vecN];
            for (int i = 0; i < vecN; i++)
            {
                Console.Write($"Введите vec[{i}] -> ");
                while (!int.TryParse(Console.ReadLine(), out vec[i]))
                {
                    Console.Write($"Введены недопустимые данные! Число должно быть целым!\nВведите vec[{i}] -> ");
                }
            }

            Console.Write("Вектор: ");
            PrintOneDArray(vec);

            for (int i = 0; i < N; i++)
            {
                if ((i + 1) % 2 != 0)
                    arr[i] = vec;
            }

            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < N; i++)
            {
                PrintOneDArray(arr[i]);
            }
        }
    }
}
