using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace countgood
{
    class Program
    {
        //Семенов Дмитрий Алексеевич
        /**Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
         * Хорошим называется число, которое делится на сумму своих цифр.
         * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
         */
        static void Main(string[] args)
        {
            int answer = 0;
            int max = 1000000;
            DateTime time1 = DateTime.Now;
                for (int i = 1; i <= max; i++)
                {
                    int sum = payment(i);

                    if (i % sum == 0)
                    {
                        answer =answer+ i ;
                    }
                }
            
            DateTime time2 = DateTime.Now;
            Console.WriteLine("Сумма 'хороших' чисел "+answer);
            Console.WriteLine("Время выполнения: {0}", (time2 - time1).Milliseconds + " миллисекунд");
            Console.ReadKey();

        }


        public static int  payment(int i)
        {
            int result = 0;
              while  (i >= 1) {
               result+= i % 10;
               i = i / 10;
            }
              
                return result;
                
            }
    }
}
