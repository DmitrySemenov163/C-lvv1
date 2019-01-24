using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace human
{
    class Program
    {
        //Семенов Дмитрий Алексеевич
        /*а) Написать программу, которая запрашивает массу и рост человека, 
         * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
          б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу человека в кг");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост в сантиметрах");
            double userHeight = Convert.ToDouble(Console.ReadLine()) / 100;
            calculation(userWeight, userHeight);
        }

        static void calculation(int userWeight, double userHeight)
        {
            double norm = Math.Round(20 * Math.Pow(userHeight, 2), 2);
            double result = Math.Round(userWeight / Math.Pow(userHeight, 2), 2);
            Console.WriteLine("Ваш индекс массы тела " + result);
            if (result <= 18.5)
            {
                Console.WriteLine("Вам необходимо добрать в весе " + (norm - userWeight));
            }
            else if (result > 18.5 && result < 25)
            {
                Console.WriteLine("Ваш вес в норме ");
            }
            else if (result >= 25)
            {
                Console.WriteLine("Вам необходимо сбросить в весе " + (userWeight - norm));
            }
            Console.ReadKey();
        }
    }
}
