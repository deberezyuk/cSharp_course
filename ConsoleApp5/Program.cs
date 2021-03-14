//Написать метод подсчета количества цифр числа.
//Березюк Денис

using System;

namespace Task2
{
    class Program
    {
        static int DigitCount(int n)
        {
            int counter = 0;
            while (n > 0)
            {
                n = n / 10;
                counter++;
            }
            return counter;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество цифр в числе: " + DigitCount(n));
        }
    }
}
