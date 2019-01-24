using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loop
{
    //Семенов Дмитрий Алексеевич
    /*С клавиатуры вводятся числа, пока не будет введен 0. 
     * Подсчитать сумму всех нечетных положительных чисел.
     */
    static
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите последовательно числа");
            int a;
            int sum = 0;
            while (true) {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && ( a % 2 != 0)) 
                {
                    sum += a;
                    }
                else if (a == 0) {
                    break;    
                }
            }

            Console.WriteLine("Сумма чисел равна "+sum);
            Console.ReadKey();
        }
    }
}
