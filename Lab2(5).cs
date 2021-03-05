using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str.ToUpper()[i] && !(str[i] >= 32 && str[i] <= 127)) count++;
            }
            Console.WriteLine("Количество заглавных букв в строке, не входящих в английский алфавит: " + count);
        }
    }
}
