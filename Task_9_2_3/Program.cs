using System;

namespace Task_9_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Ошибка");
            }
            catch(Exception ex) when (ex is RankException)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
