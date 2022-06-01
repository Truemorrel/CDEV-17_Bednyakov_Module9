using System;

namespace Task_9_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyException newException = new MyException("Возникло исключение:");
            newException.HelpLink = "www.duckduckgo.com";

        }
    }
    public class MyException:Exception
    {
        public MyException() : base()
        {

        }
        public MyException(string mes) : base(mes)
        {
        
        }

        
    }
}
