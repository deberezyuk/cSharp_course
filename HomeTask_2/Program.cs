using System;

namespace HomeTask_2
{
    class indexCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            double weight = Convert.ToDouble(Console.ReadLine());

            double massIndex = (weight / (height * height));

            Console.WriteLine("Ваш индекс массы тела: " + massIndex);

        }
    }
}
