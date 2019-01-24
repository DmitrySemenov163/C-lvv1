using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace min
{
    class Program
    {
    //Семенов Дмитрий Алексеевич
    /*Написать метод, возвращающий минимальное из трех чисел.
     */
    stat
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            LocationsMin(a, b, c);
            
        }


         static void LocationsMin(Int32 a, Int32 b, Int32 c)
        {
            var result = a < b && a < c ? a : b > c ? c : b;
            Console.WriteLine("Минимальное число " + result);
            Console.ReadKey();
        }
    }
}
