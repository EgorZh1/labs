using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2__
{
    class Program
    {
        private static void Per(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    Per(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }

        public static string Swap(string str, int i, int j)
        {
            var chA = str.ToCharArray();
            char temp = chA[i];
            chA[i] = chA[j];
            chA[j] = temp;
            return new String(chA);
        }

        public static void Main()
        {
            string str;
            str = Console.ReadLine();
            Per(str, 0, str.Length-1);
        }

    }
}
