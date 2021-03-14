//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
//Березюк Денис


using System;

namespace Task4
{
    class Program
    {
        static bool CheckLoginPassord(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                if (CheckLoginPassord(login, password) == true)
                {
                    Console.WriteLine("Логин и пароль правильные");
                    count = 3;
                }
                else
                {
                    Console.WriteLine("Логин и пароль неправильные");
                    count++;
                }
            }
        }
    }
}
