using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static Random rnd = new Random();
        static void FillArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        static int SumArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            FillArray(mas);
            Console.WriteLine("Array:");
            PrintArray(mas);
            Console.WriteLine($"Sum = {SumArray(mas)}");
            Console.ReadKey();
        }
    }
}
