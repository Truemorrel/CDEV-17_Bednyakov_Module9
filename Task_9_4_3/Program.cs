using System;

namespace Task_9_4_3
{
    internal class Program
    {
        delegate void Human(Chield man);
        static void Main(string[] args)
        {
            Human WhoIsThis = GetParentInfo;
            WhoIsThis.Invoke(new Chield());
        }
        public static void GetParentInfo (Parent person)
        {
            Console.WriteLine(person.GetType());
        }
    }
    class Parent
    {

    }
    class Chield : Parent
    {

    }
}
