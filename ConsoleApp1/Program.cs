using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:F2}", Distance(x1, x2, y1, y2));
        }
    }
}
