using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0, num, ranum;
            
            Console.Write("Введите количество чисел -");
            n = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            Student a1 = new Student(n);
            
            for(int i=0; i<n; i++)
            {
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Количество символов - {0}", a1.leng);
            
            for (int i = 0; i < n; i++)
            {
                sum += a1[i];
                s = a1.
            }
            Console.WriteLine("Сумма чисел - {0}", sum);
            Console.WriteLine("Угадай число.");
            ranum = rand.Next(1, sum + 1);
          //  Console.WriteLine(ranum);
            do
            {
               num = Convert.ToInt32(Console.ReadLine());
               if (Student.Enter(num, ranum) == 1) break;
            } while (true);
            
            Console.ReadLine();
        }
    }
}