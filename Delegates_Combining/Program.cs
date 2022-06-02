﻿using System;

public class Program
{
    public delegate void ShowDelegate();
    static void Main(string[] args)
    {

        ShowDelegate showDelegate1 = ShowMessage1;
        showDelegate1 += ShowMessage2;

        ShowDelegate showDelegate2 = ShowMessage3;
        showDelegate2 += ShowMessage4;

        ShowDelegate showDelegate3 = showDelegate1 + showDelegate2;

        showDelegate3.Invoke();

        Console.ReadKey();
    }

    static void ShowMessage1()
    {
        Console.WriteLine("Метод 1");
    }

    static void ShowMessage2()
    {
        Console.WriteLine("Метод 2");
    }

    static void ShowMessage3()
    {
        Console.WriteLine("Метод 3");
    }

    static void ShowMessage4()
    {
        Console.WriteLine("Метод 4");
    }
}