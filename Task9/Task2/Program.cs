using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void PrintArray(DynamicArray<int> arr)
        {
            Console.WriteLine("-------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] mas = new int[4] { 1, 2, 3, 4 };
            DynamicArray<int> arr = new DynamicArray<int>(mas);
            PrintArray(arr);

            arr.Add(6);
            PrintArray(arr);

            arr.RemoveIndex(4);
            PrintArray(arr);

            arr.Insert(15, 3);
            PrintArray(arr);

            arr.SortArray();
            PrintArray(arr);

            arr.Remove(15);
            PrintArray(arr);

            arr.SortArray();
            PrintArray(arr);

            Console.WriteLine("-------");
            foreach (int el in arr)
            {
                Console.WriteLine(el);
            }

            IEnumerable<int> arrayNew = new int[5] { 2, 5, 2, 5, 2};
            DynamicArray<int> arr1 = new DynamicArray<int>(arrayNew);
            Console.WriteLine("-------");
            foreach (int el in arr1)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }     
    }
}
