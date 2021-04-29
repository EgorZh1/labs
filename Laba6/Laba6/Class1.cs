using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    interface IComparable
    {
        void CompareTo();
    }
    public interface I_Fig
    {
        int G_P();
        int G_A();
    }
    public class Class1 : I_Fig, IComparable
    {
        public int x,z;
        public Class1(int a, int b)
        {
            x = a;
            z = b;
        }
        public void CompareTo()
        {
            if (x > z) Console.WriteLine("X > Z");
            if (z > x) Console.WriteLine("Z > X");
        }
        public int G_A()
        {
            return x*z;
        }
        public int G_P()
        {
            return 2*(x+z);
        }
    }
}
