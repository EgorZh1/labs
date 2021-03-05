using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string s = Console.ReadLine();


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s.ToUpper()[i] && !(s[i] >= 32 && s[i] <= 127)) x++;
            }
            Console.WriteLine("Количество заглавных букв в строке, не входящих в английский алфавит: " + x);
        }
    }
}
