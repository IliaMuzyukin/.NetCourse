using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static Random rnd = new Random();
        static void FillArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(-100, 100);
                    }
                }
            }
        }
        static void NulArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        static void PrintArray (int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Index i --{i}--");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Index j --{j}--");
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]}, ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,,] mas = new int[5, 5, 5];
            FillArray(mas);
            Console.WriteLine("First array");
            PrintArray(mas);
            NulArray(mas);
            Console.WriteLine("Second array");
            PrintArray(mas);
            Console.ReadKey();
        }
    }
}
