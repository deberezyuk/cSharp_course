//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;

namespace ConsoleApp8
{
    class Program
    {
        static double getMassIndex(double height, double mass)
        {
            double index = (mass / (height * height));
            return index;
        }
        static void getRecommendation(double index, double height, double mass)
        {
            Console.WriteLine(index.ToString());
            string resume = "";
            if (index < Convert.ToDouble(19))
            {
                double toGainMass = height * height * 19 - mass;
                resume = $"У вас недостаточная масса тела. До нормального веса наберите {toGainMass} кг";
            }
            else if (index > Convert.ToDouble(25))
            {
                double toLossMass = mass - height * height * 25;
                resume = $"У вас избыточная масса тела. До нормального веса сбросьте {toLossMass} кг";
            }
            else
            {
                resume = "У вас нормальная масса тела";
            }
            Console.WriteLine(resume);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вашу массу тела в кг: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double index = getMassIndex(height, weight);
            getRecommendation(index, height, weight);
        }
    }
}
