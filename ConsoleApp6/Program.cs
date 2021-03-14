//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Березюк Денис

using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        //static int Sum(List<int> digitList)
        //{
        //    for (int i = 0; i < digitList.Count; i++)
        //    {
        //        int sum = 0;
        //        if (digitList[i]%2 != 0 && digitList[i] > 0)
        //        {
        //            sum = sum + digitList[i];
        //        }
        //        else
        //        {
        //            Console.WriteLine("Число четное или отрицательное");
        //        }
        //        return sum;
        //    }
        //}
        static void Main(string[] args)
        {
            //Костыль - зададим digit=1, чтобы "войти" в цикл
            int digit = 1;
            int sum = 0;
            while (digit != 0)
            {
                Console.WriteLine("Введите число: ");
                digit = Convert.ToInt32(Console.ReadLine());
                if (digit%2 != 0 && digit > 0)
                {
                    sum = sum + digit;
                }
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
