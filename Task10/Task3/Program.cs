using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    public delegate bool CompareString(string s1, string s2);

    class Program
    {
        static bool Compare(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return true;
            }
            else if (s1.Length < s2.Length)
            {
                return false;
            }
            else if (string.Compare(s1, s2) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            ArraySort newArray1 = new ArraySort();
            newArray1.ArrayString = new string[5] { "lalala", "ese", "ewewe", "feeee", "mur" };
            newArray1.Name = "Array 1";
            ArraySort newArray2 = new ArraySort();
            newArray2.ArrayString = new string[8] { "lalala", "ese", "ewewe", "feeee", "mur", "edl", "zasss", "ljjjkjjj" };
            newArray2.Name = "Array 2";
            newArray2.SortFinish += newArray1.Print;
            newArray2.SortFinish += newArray2.Print;
            CompareString comp = new CompareString(Compare);
            ThreadStart sort = () => 
            {
                newArray1.SortString(comp);
            };
            Thread myThread = new Thread(sort);
            myThread.Start();
            newArray2.SortString(comp);
            //myThread.Join();
            //ThreadStart printArr1 = () =>
            //{
            //    newArray1.Print();
            //};
            //Thread myThread2 = new Thread(printArr1);
            //ThreadStart printArr2 = () =>
            //{
            //    newArray2.Print();
            //};
            //Thread myThread3 = new Thread(printArr2);
            //Console.WriteLine("------");
            //myThread2.Start();
            //myThread3.Start();
            Console.WriteLine("------");
            Console.WriteLine("Stop");
            Console.ReadKey();
        }
    }
}
