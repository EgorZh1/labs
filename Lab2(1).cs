using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_
{
    class Program
    {
        static void Main()
        {
            DateTime date = DateTime.Now;
            int[] s = new int[10];
            string str1 = Convert.ToString(date), str2 = Convert.ToString(date.ToString("F"));
            
            for (int i = 0; i < str1.Length; i++) if (str1[i] >= 48 && str1[i] <= 57) s[str1[i] - 48]++;
            
            Console.WriteLine("Текущее время (1):  " + str1);
            for (int i = 0; i < 10; i++) Console.WriteLine("Количество символов " + '\'' + i + "\' = " + s[i]);
            for (int i = 0; i < 10; i++) s[i] = 0;

            for (int i = 0; i < str2.Length; i++) if (str2[i] >= 48 && str2[i] <= 57) s[str2[i] - 48]++;
            
            Console.WriteLine("\n\n\nТекущее время (2):  " + str2);
            for (int i = 0; i < 10; i++) Console.WriteLine("Количество символов " + '\'' + i + "\' = " + s[i]);
            
        }
    }
}
