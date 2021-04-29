using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    class Program
    {
        enum Oper
        {
            One=1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten
        }
        static void Main(string[] args)
        {
            Oper s;

            int l, w;

            Console.Write("Введите длину l:= ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите ширину w:= ");
            w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Перечесления");
            s = Oper.One;
            Console.WriteLine((int)s);
            s = Oper.Ten;
            Console.WriteLine((int)s);
            
            Console.WriteLine();
            var Classes = new List<Math>
            {
                new M1(l,w),
                new M2(l,w)
            };
            foreach (var i in Classes) i.Schet();
          
        }
    }
}
