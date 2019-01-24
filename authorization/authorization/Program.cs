using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace authorization
{
    class Program
    {
      //Семенов Дмитрий Алексеевич
        /*Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками
         */
        static void Main(string[] args)
        {
            string login = "root";
            string password = "GeekBrains";
            int countAttempt = 3;//колличество попыток
            auto(login,password,countAttempt);
        }

          static void  auto(string login, string password,int countAttempt)
        {
             int i=0;
             string userLogin, userPassword;
             do
             {
                 Console.WriteLine("Введите логин");
                 userLogin = Convert.ToString(Console.ReadLine());
                 Console.WriteLine("Введите пароль");
                 userPassword = Convert.ToString(Console.ReadLine());
                 if (userLogin == login && userPassword == password)
                 {
                     Console.WriteLine("Логин и пароль введен верно");
                     break;
                 }
                 else
                 {
                     i++;
                     Console.WriteLine("Неверно, у Вас осталось " + (countAttempt - i) + " попыток");
                 }
             }
             while (i < countAttempt);
             Console.ReadKey();
        }
    }
}
