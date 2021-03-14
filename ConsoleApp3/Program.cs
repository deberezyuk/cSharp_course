using System;

namespace ConsoleApp3
{
    class Program
    {
        //пункт в
        static string GetUserData(string name, string surname, string city)
        {
            string msg = $"Вы {name} {surname} из города {city}";
            return msg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Ваш город : ");
            string city = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(GetUserData(name, surname, city));

            //пункт а
            Console.WriteLine("Ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия: ");
            surname = Console.ReadLine();
            Console.WriteLine("Ваш город : ");
            city = Console.ReadLine();
            Console.SetCursorPosition(30, 30);
            Console.WriteLine($"Вы {name} {surname} из города {city}");
        }
    }
}
