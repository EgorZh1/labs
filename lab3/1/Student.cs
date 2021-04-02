using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1_
{
    class Student
    {
        int[] a;
        public int leng;
        public Student(int size)
        {
            a = new int [size];
            leng = size;
        }
        public int this[int index]
        {
            set { a[index] = value; }
            get { return a[index]; }
        }
        static public int Enter(int num,int ranum)
        {
            if (num > ranum) Console.WriteLine("Загаданное число меньше!");
            else if (num < ranum) Console.WriteLine("Загаданное число больше!");
            else
            {
                Console.WriteLine("Ты угадал )");
                return 1;
            }
            return 0;
        }
    }
}
