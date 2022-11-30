using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_6._1_Console
{
    internal class Program
    {
        static void OutArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите число элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Были введены неверные данные! Число элементов массива должно быть > 0! " +
                    "Введите число элементов массива: ");
            }
            double[] array = new double[N];

            Console.WriteLine("Заполните массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите значение элемента array[{i}]: ");
                while (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Были введены неверные данные! " +
                        $"Введите значение элемента array[{i}]: ");
                }
            }

            Console.Write("Изначальный массив: ");
            OutArray(array);
            Console.WriteLine();
            
            for (int i = 0; i < N; i++)
                if (array[i] < 0 && array[i] % 3 != 0) array[i] *= -1;

            Console.Write("Изменненный массив: ");
            OutArray(array);
        }
    }
}
