using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_
{
    class Program
    {
        static void Main()
        {
            string a, b;

            Console.Write("Игрок №1, Введите никнейм: ");
            a = Console.ReadLine();
            Console.Write("Игрок №2, Введите никнейм: ");
            b = Console.ReadLine();

            bool f = true;
            Random rand = new Random();
            int n = rand.Next(20, 31), m;
            while (n > 0)
            {
                Console.WriteLine("Текущее число: " + n);
                Console.WriteLine("{0}, введите число от 1 - 4", f ? a : b);
                if (f)
                {
                    m = int.Parse(Console.ReadLine());
                    while (!(m >= 1 && m <= 4))
                    {
                        Console.WriteLine("Неверный ответ {0}, повторите ввод", f ? a : b);
                        m = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    m = rand.Next(1, 5);
                    if(n<=4)
                    {
                        m = n;
                        Console.WriteLine(a + "походил" + m);
                    }
                    else Console.WriteLine(b + " походил " + m);

                }

                n -= m;
                f = !f;
            }
            Console.WriteLine(0);
            Console.WriteLine("{0} победил!", f ? b : a);
            Console.ReadKey();
        }
    }
}
