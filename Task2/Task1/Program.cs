using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static Random rnd = new Random();
        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
        }
        static int MaxArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int MinArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void InsertionSortArray(int[] arr)
        {
            int value = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                value = arr[i];
                int j = i;
                while ((j > 0) && (value < arr[j - 1]))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = value;
            }
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            FillArray(arr);
            Console.WriteLine("Start array:");
            PrintArray(arr);
            InsertionSortArray(arr);
            Console.WriteLine("Sort array:");
            PrintArray(arr);
            Console.WriteLine($"Max element of array: {MaxArray(arr)}");
            Console.WriteLine($"Min element of array: {MinArray(arr)}");
            Console.ReadKey();
        }
    }
}
