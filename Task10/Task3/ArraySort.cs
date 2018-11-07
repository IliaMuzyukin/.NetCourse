using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class ArraySort
    {
        public string[] ArrayString { get; set; }

        public string Name { get; set; }

        public void SortString(CompareString comp)
        {
            for (int i = 0; i < ArrayString.Length - 1; i++)
            {
                for (int j = i + 1; j < ArrayString.Length; j++)
                {
                    if (comp(ArrayString[i], ArrayString[j]))
                    {
                        string s = ArrayString[i];
                        ArrayString[i] = ArrayString[j];
                        ArrayString[j] = s;
                    }
                    Thread.Sleep(100);
                }
            }
            if (SortFinish != null)
            {
                SortFinish();
            }
        }

        public delegate void PrintArray();

        public event PrintArray SortFinish;
        public void Print()
        {
            for (int i = 0; i < ArrayString.Length; i++)
            {
                Console.WriteLine($" {Name} - {ArrayString[i]}");
                Thread.Sleep(100);
            }
        }
    }
}
