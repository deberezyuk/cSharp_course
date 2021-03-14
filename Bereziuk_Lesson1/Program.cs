using System;

namespace Bereziuk_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = AskInteger();

            Console.Write("Введите второе число");
            int second = Convert.ToInt32(Console.ReadLine());

            var sum = first + second;
            Console.WriteLine(sum);
        }

        private static int AskInteger()
        {
            Console.Write("Введите первое число");
            int first = Convert.ToInt32(Console.ReadLine());
            return first;
        }
    }
}
