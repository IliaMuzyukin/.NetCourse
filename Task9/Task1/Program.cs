using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void RemoveEachSecondItem<T>(ICollection<T> list)
        {
            bool isEven = false;
            while (list.Count > 1)
            {
                var evenElements = new List<T>();
                foreach (var item in list)
                {
                    if (isEven)
                    {
                        evenElements.Add(item);
                    }
                    isEven = !isEven;
                }

                foreach(var item in evenElements)
                {
                    list.Remove(item);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] people = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> myList = new List<int>(people);
            LinkedList<int> myLinked = new LinkedList<int>(people);
            RemoveEachSecondItem(myList);
            RemoveEachSecondItem(myLinked);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
            foreach (int i in myLinked)
            {
                Console.WriteLine(i);
            }
            string[] people1 = new string[12] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "M", "N", "L" };
            List<string> myList1 = new List<string>(people1);
            LinkedList<string> myLinked1 = new LinkedList<string>(people1);
            RemoveEachSecondItem(myList1);
            RemoveEachSecondItem(myLinked1);
            foreach (string i in myList1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
            foreach (string i in myLinked1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
