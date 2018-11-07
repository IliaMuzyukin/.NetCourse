using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        public delegate bool CompareString(string s1, string s2);

        static bool Compare (string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return (s1.Length > s2.Length);
            }
            else
            {
                return (string.Compare(s1, s2) == 0);
            }
        }

        public static void SortString (string[] arrayStr, CompareString comp)
        {
            for (int i = 0; i < arrayStr.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayStr.Length; j++)
                {
                    if (comp(arrayStr[i], arrayStr[j]))
                    {
                        string s = arrayStr[i];
                        arrayStr[i] = arrayStr[j];
                        arrayStr[j] = s;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string[] arrayStr = new string[5] { "car", "char", "sharp", "sdr", "rlt"};
            CompareString comp = new CompareString(Compare);
            SortString(arrayStr, comp);
            for (int i = 0; i < arrayStr.Length; i++)
            {
                Console.WriteLine(arrayStr[i]);
            }
            Console.ReadKey();
        }
    }
}
