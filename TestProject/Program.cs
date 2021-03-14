using System;

class form
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Ваше фамилия: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Ваш возраст: ");
        double age = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ваш рост: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ваш вес: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        // пункт а
        Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
        // пункт б
        Console.WriteLine("Ваше имя {0}, Ваша фамилия {1}, возраст {2}, рост {3}, вес {4}", name, surname, age, height, weight);
        // пункт с
        Console.WriteLine($"Ваше имя {name}, ваша фамилия {surname}, возраст {age}, рост {height}, вес {weight}");
    }
}

