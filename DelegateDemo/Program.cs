using System;

namespace DelegateDemo
{
    public class AnonymousMethods
    {
        public delegate string GreetingsDelegate(string name);
        public static string Greetings(string name)
        {
            return "Привет @" + name + "! Добро пожаловать на SkillFactory!";
        }

        static void Main(string[] args)
        {
            GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
            string GreetingsMessage = gd.Invoke("Будущий гуру");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}

