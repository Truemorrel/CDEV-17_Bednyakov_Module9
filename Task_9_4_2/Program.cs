using System;

namespace Task_9_4_2
{
    internal class Program
    {
        delegate Car MotorDelegate();
        public static Car CarMethod()
        {
            return null;
        }
        public static Lexus lexusMethod()
        {
            return null;
        }
        static void Main(string[] args)
        {
            MotorDelegate carDelegate = CarMethod;
            MotorDelegate lexusDelegate = lexusMethod;
            Console.ReadKey();
        }
    }

    class Car { };
    class Lexus : Car { };
}
