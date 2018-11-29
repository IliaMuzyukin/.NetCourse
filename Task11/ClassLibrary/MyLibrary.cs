using System;

namespace ClassLibrary
{
   public static class MyLibrary
    {
        public static int Fact(this int x)
        {
            return (x == 0) ? 1 : x * Fact(x - 1);
        }

        public static int Pow(this int x, int p)
        {
            return (int)Math.Pow(x,p);
        }
    }
}
