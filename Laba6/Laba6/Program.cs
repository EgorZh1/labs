using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width;
            Console.Write("Dlina: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Shirina: ");
            width = Convert.ToInt32(Console.ReadLine());

            Class1 r = new Class1(length,width);
            Console.WriteLine("Area is: {0}" ,r.G_A());
            Console.WriteLine("Perimeter is: {0}\n" ,r.G_P());

        }
    }
}
