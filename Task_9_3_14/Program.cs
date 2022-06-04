using System;

namespace Task_9_3_14
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = (_message) =>
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.ReadKey();
        }

    }
}

