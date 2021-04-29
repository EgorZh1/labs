using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public abstract class Math
    {
        public abstract int Schet();
    }
    public class M1: Math
    {
        public int length, width;
        public M1(int a, int b)
        {
            length = a;
            width = b;
        }
        public override int Schet()
        {
            Console.WriteLine("Вы не переопределили метод\n"+(length * width)+"\n");
            return (length * width);
        }
    }
     public class M2: Math
     {
         public int length, width;
         public M2(int a, int b)
         {
             length = a*2;
             width = b*2;
         }
         public override int Schet()
         {
             Console.WriteLine("Вы переопределили метод\n"+(length * width)+"\n");
             return (length * width);
         }

     }
}
