using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    abstract class Human
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public int age { get; set; }

        public abstract float addBalance();

        public virtual bool checkForDismiss()
        {
            bool ret = false;

            if (age > 80)
                ret = true;

            return ret;
        }
        public static void writeHumanProfession(Human _human)
        {
            Console.WriteLine(_human.GetType().Name);
        }
    }
    class Student : Human
    {
        protected int physics;
        protected int math;
        protected int rysk;

        public Student(string name, string surname, string patronymic, int age,
            int physics, int math, int rysk)
        {

            if (physics >= 0 && physics <= 10)
            {
                this.physics = physics;
            }
            else
            {
                Console.WriteLine("This point must be in [0,10].");
                Console.ReadLine();
                Console.Clear();
                return;

            }
            if (math >= 0 && math <= 10)
            {
                this.math = math;
            }
            else
            {
                Console.WriteLine("This point must be in [0,10].");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            if (rysk >= 0 && rysk <= 10)
            {
                this.rysk = rysk;
            }
            else
            {
                Console.WriteLine("This point must be in [0,10].");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }

        public override float addBalance()
        {
            float scholarship;

            if (this.getAverage() > 8.0)
            {
                scholarship = 115; // rubles;
            }
            else
            {
                scholarship = 60;
            }

            return scholarship;
        }

        public float getAverage()
        {
            return (this.physics + this.rysk + this.math) / 3;
        }
        public void AreyouEnter(float srbal)
        {
            Console.WriteLine("Enter your results of CT:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Incorrect enter");
                Console.Clear();
                return;
            }
            else if (a > 100 || b > 100 || c > 100)
            {
                Console.WriteLine("Each score can be only <=100");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            float itog = a + b + c + srbal * 10;
            Console.WriteLine($"My score - {itog}");

            Console.WriteLine("Are you applying for free or paid?\n 3 - paid \n 4 - free");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 3:
                    if (itog < 150)
                    {
                        Console.WriteLine("You are not enter to any specialization");
                    }
                    else if (250 > itog && itog >= 150)
                    {
                        Console.WriteLine("Choose the specialization:\n 1 - VMSIS \n 2 - IVS");
                        int N = Convert.ToInt32(Console.ReadLine());
                        switch (N)
                        {
                            case 1: Console.WriteLine("You are enter to VMSIS"); break;
                            case 2: Console.WriteLine("You are enter to IVS"); break;
                            default: Console.WriteLine("Incorrect enter"); break;
                        }
                    }
                    else if (400 >= itog && itog >= 250)
                    {
                        Console.WriteLine("Choose the specialization:\n 1 - IITP \n 2 - POIT \n 3 - VMSIS \n 4 - IVS");
                        int N = Convert.ToInt32(Console.ReadLine());
                        switch (N)
                        {
                            case 1: Console.WriteLine("You are enter to IITP"); break;
                            case 2: Console.WriteLine("You are enter to POIT"); break;
                            case 3: Console.WriteLine("You are enter to VMSIS"); break;
                            case 4: Console.WriteLine("You are enter to IVS"); break;
                            default: Console.WriteLine("Incorrect enter"); break;
                        }
                    }
                    break;
                case 4:
                    if (itog < 250)
                    {
                        Console.WriteLine("You are not enter to any specialization");
                    }
                    if (itog >= 250 && itog < 300)
                    {
                        Console.WriteLine("Choose the specialization:\n 1 - VMSIS \n 2 - IVS ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        switch (N)
                        {
                            case 1: Console.WriteLine("You are enter to VMSIS"); break;
                            case 2: Console.WriteLine("You are enter to IVS"); break;
                            default: Console.WriteLine("Incorrect enter"); break;
                        }
                    }
                    if (itog >= 300 && itog <= 400)
                    {
                        Console.WriteLine("Choose the specialization:\n 1 - VMSIS \n 2 - IVS \n 3 - IITP \n 4 - POIT");
                        int N = Convert.ToInt32(Console.ReadLine());
                        switch (N)
                        {
                            case 1: Console.WriteLine("You are enter to VMSIS"); break;
                            case 2: Console.WriteLine("You are enter to IVS"); break;
                            case 3: Console.WriteLine("You are enter to IITP"); break;
                            case 4: Console.WriteLine("You are enter to POIT"); break;
                            default: Console.WriteLine("Incorrect enter"); break;
                        }
                    }
                    break;
                default: Console.WriteLine("Incorrect enter"); break;
            }
        }
    }

    class Staff : Human
    {
        public float WorkHours { get; set; }
        public override float addBalance()
        {
            return WorkHours * 10; // 10 - base payment value / hour
        }

        public override bool checkForDismiss()
        {
            bool ret = false;

            if (WorkHours < 40)
            {
                ret = true;
            }
            return ret;
        }
    }

    class Lecturer : Human
    {
        public int LecturesCount { get; set; }
        public override float addBalance()
        {
            return LecturesCount * 14; // 14 - base payment value / lecture
        }
    }
    enum Operations
    {
        Staff = 1,
        Lecturers
    }

    class Program
    {
        delegate void Stud(string message);
        event Stud Notify;
        public void Before(int person)
        {
            person = 4;
            Notify?.Invoke($"Работающие до проверки: {person}");
        }
        public void After(int person)
        {
            person = 2;
            if (person > 2)
            {
                Notify?.Invoke($"Уволено: {person}");
            }
            if (person < 2)
            {
                Notify?.Invoke($"Работает: {person}");
            }
        }

        delegate string Delegate(string count);
        Delegate delegat = (string x) => { return x; };

        static void Speciality(Operations op)
        {
            switch (op)
            {
                case Operations.Staff:
                    Staff staff1 = new Staff();
                    staff1.name = "Ludmila";
                    staff1.surname = "Babicheva";
                    staff1.patronymic = "Alekseevna";
                    staff1.age = 40;
                    staff1.WorkHours = 100;

                    Staff staff2 = new Staff();
                    staff2.name = "Kirill";
                    staff2.surname = "Ivanov";
                    staff2.patronymic = "Andreevich";
                    staff2.age = 40;
                    staff2.WorkHours = 30;

                    Human.writeHumanProfession(staff1);
                    Console.WriteLine("st1 :" + staff1.name + "  dismiss?  " + staff1.checkForDismiss());
                    Human.writeHumanProfession(staff2);
                    Console.WriteLine("st2 :" + staff2.name + "  dismiss?  " + staff2.checkForDismiss());
                    break;
                case Operations.Lecturers:
                    Lecturer lecturer1 = new Lecturer();
                    lecturer1.name = "Kolya";
                    lecturer1.surname = "Byhov";
                    lecturer1.patronymic = "Maximovich";
                    lecturer1.age = 40;
                    lecturer1.LecturesCount = 10;

                    Lecturer lecturer2 = new Lecturer();
                    lecturer2.name = "Ekaterina";
                    lecturer2.surname = "Vladimirovna";
                    lecturer2.patronymic = "Snopich";
                    lecturer2.age = 83;
                    lecturer2.LecturesCount = 5;

                    Human.writeHumanProfession(lecturer1);
                    Console.WriteLine("lc1 :" + lecturer1.name + " dismiss? " + lecturer1.checkForDismiss());
                    Human.writeHumanProfession(lecturer2);
                    Console.WriteLine("lc2 :" + lecturer2.name + " dismiss? " + lecturer2.checkForDismiss());
                    break;
            }

        }
        static void Main(string[] args)
        {
            Student student;
            int age = 0, math = 0, physics = 0, rysk = 0;
            string name = "Name", surname = "Surname", patronymic = "Patronymic";

            try
            {
                Console.WriteLine("Enter surname");
                surname = Console.ReadLine();
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter patronymic");
                patronymic = Console.ReadLine();
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter physics grade");
                physics = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter math grade");
                math = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter rysk grade");
                rysk = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect enter");
                return;
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            float srbal = (physics + math + rysk) / 3;

            student = new Student(name, surname, patronymic, age, physics, math, rysk);

            int i = 0;
            for (; ; )
            {
                Console.WriteLine("\n1 - Are you enter?\n2 - Check stuff\n3 - Check lecturer");
                int operat = Convert.ToInt32(Console.ReadLine());

                switch (operat)
                {
                    case 1: student.AreyouEnter(srbal); break;
                    case 2: Speciality(Operations.Staff); break;
                    case 3: Speciality(Operations.Lecturers); break;
                    default: Console.Clear(); break;
                }
                i++;
                if (i == 4)
                    break;
            }
            Console.ReadLine();
        }
    }
}