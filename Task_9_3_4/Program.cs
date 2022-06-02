using System;

namespace Task_9_3_4
{
    internal class Program
    {
        public delegate void Func(int x, int y);
        static void Main(string[] args)
        {
            Func func = Function1;
            func += Function2;
            func.Invoke(5, 6);
            ;
        }
        static void Function1(int a, int b)
        {
            Console.WriteLine("5 - 6 = {0}", a - b);
        }
        static void Function2(int a, int b)
        {
            Console.WriteLine("5 + 6 = {0}", a + b);
        }
    }
}
