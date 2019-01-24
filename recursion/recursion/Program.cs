using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace recursion
{
    //Семенов Дмитрий Алексеевич
    /* a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Rec(a,b);
            int sum = 0;
            SumRec(a, b,sum);
            Console.ReadKey();
        }

        private static void SumRec(int a, int b, int sum)
        {
            if (a <= b)
            {
                sum += b;
                SumRec(a, b - 1, sum);

            }
            else {
                Console.WriteLine("\n сумма чисел от в последовательности " + sum);
            }

        }
         static void Rec(int min,int max)
        {
            if (min<=max)
            {
                
                Rec(min,max - 1);
                Console.Write(" " + max);
            }
        }
    }
}
