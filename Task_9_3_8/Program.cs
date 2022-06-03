using System;

namespace Generic_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action <string, string> showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke("Hello World", "");

            Func <int, int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            Predicate <string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);
        }
        static void ShowMessage(string msg, string msg1)
        {
            Console.WriteLine(msg + msg1);
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }
}
