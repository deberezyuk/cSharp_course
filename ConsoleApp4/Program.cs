//Написать метод, возвращающий минимальное из трёх чисел.
//Березюк Денис
using System;

namespace ConsoleApp4
{
    class Program
    {
        static int GetMinNumber(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                if (y > z) 
                {
                    return z;
                }
                else
                {
                    return y;
                }
            }
            else
            {
                return x;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Наименьшее число: " + GetMinNumber(x, y, z).ToString());
        }
    }
}
