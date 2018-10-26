using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
        static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] mas = new int[20];
            FillArray(mas);
            Console.WriteLine($"Start array {string.Join(", ", mas)}");
            Console.WriteLine($"Sum = {SumArray(mas)}");
            Console.ReadKey();
        }
    }
}
