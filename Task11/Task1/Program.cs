using System;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            x = x.Fact();
            Console.WriteLine(x);

            int y = 5;
            int power = 3;

            y = y.Pow(power);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
