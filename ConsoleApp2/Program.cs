using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пункт а
            int a = 5;
            int b = 7;
            int t = a;
            a = b;
            b = t;
            Console.WriteLine(a.ToString() + " " + b.ToString());
            // Пункт b
            a = 5;
            b = 7;
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine(a.ToString() + " " + b.ToString());

        }
    }
}
