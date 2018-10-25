using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[4] { 1, 2, 3, 4 };
            DynamicArray<int> arr = new DynamicArray<int>(mas);
            Console.WriteLine("-------");
            PrintArray(arr);

            Console.WriteLine("-------");
            arr.Add(6);
            PrintArray(arr);

            Console.WriteLine("-------");
            arr.RemoveIndex(4);
            PrintArray(arr);

            Console.WriteLine("-------");
            arr.Insert(15, 3);
            PrintArray(arr);

            Console.WriteLine("-------");
            arr.SortArray();
            PrintArray(arr);

            arr.Remove(15);
            PrintArray(arr);

            Console.WriteLine("-------");
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
        static void PrintArray(DynamicArray<int> arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
     
    }
}
