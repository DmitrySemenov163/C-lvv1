using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СountNumbers
{
    class Program
    {
        //Семенов Дмитрий Алексеевич
        //Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            long a = Convert.ToInt64(Console.ReadLine());
            Count(a);
        }

        static void Count(Int64 a)
        {

            int i = 1;
            for (; a > 10; i++)
            {
                a = a / 10;

            }
            Console.WriteLine("Количество цифр в числе "+i);
            Console.ReadKey();
        }
    }
}
