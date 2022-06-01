using System;

namespace Task_9_3_2
{
    internal class Program
    {
        public delegate int Func(int x, int y);
        static void Main(string[] args)
        {
            Func func = Function;
            Console.WriteLine("5 - 6 = {0}", func.Invoke(5, 6));
            Console.WriteLine("5 - 6 = {0}", func(5, 6));

        }
        static int Function(int a, int b)
        {
            return a - b;
        }
    }
}
