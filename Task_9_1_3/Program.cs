using System;

namespace Task_9_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception newException = new Exception();
            newException.Data.Add("Дата создания: {0}",DateTime.Now);
            
        }
    }
}
