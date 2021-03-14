//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.


using System;

namespace ConsoleApp9
{
    class Program
    {
        static int getSumDigit()
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                while (i!=0)
                {
                    sum = sum + i % 10;
                    i = i / 10;                 
                }
                if (sum != 0)
                {
                    if (i % sum == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Решение задания: " + Convert.ToString(getSumDigit()));
        }
    }
}
