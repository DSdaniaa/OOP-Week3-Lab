using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1();
            //task2();
            //task3();
            // task4();
            //task5();
            // task6();
            //task7();
            //task8();
            Task9();
        }
        static void task1()
        {
            student s1 = new student();
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            Console.ReadKey();
        }
        static void task2()
        {
            student s1 = new student();
            student s2 = new student();
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s2.sname, s2.matricMarks, s2.fscMarks, s2.ecatMarks, s2.aggregate);
            Console.ReadKey();
        }
        static void task3()
        {
            student1 s1 = new student1("dania",20.2F,3.0F,403.2F,200);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            Console.ReadKey();
        }
        static void task4()
        {
            student1 s1 = new student1("dania", 20.2F, 3.0F, 403.2F, 200);
            student1 s2 = new student1("jill",2.4F,300,500,20.5F);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s2.sname, s2.matricMarks, s2.fscMarks, s2.ecatMarks, s2.aggregate);
            Console.ReadKey();
        }
        static void task5()
        {
            student2 s1 = new student2();
            s1.sname = "jack";
            student2 s2 = new student2(s1);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s1.sname, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);
            Console.WriteLine("name: {0} martic marks: {1} fsc marks: {2} ecat marks: {3} aggregate: {4} ", s2.sname, s2.matricMarks, s2.fscMarks, s2.ecatMarks, s2.aggregate);
            Console.ReadKey();
        }
        static void task6()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i=0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.Read();
        }
        static void task7()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
        static void task8()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in number)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
        static void Task9()
        {
            clockType empty_time = new clockType();
            Console.Write("Empty Time: ");
            empty_time.printTime();
            clockType hour_time = new clockType(8);
            Console.Write("Hour Time: ");
            hour_time.printTime();
            clockType minute_time = new clockType(8,10);
            Console.Write("Minute Time: ");
            minute_time.printTime();
            clockType full_time = new clockType(8,10,10);
            Console.Write("Full Time: ");
            full_time.printTime();
            full_time.increamentSeconds();
            Console.Write("Full Time (increment second): ");
            full_time.printTime();
            full_time.increamentMinutes();
            Console.Write("Full Time (increment Minute): ");
            full_time.printTime();
            full_time.increamentHours();
            Console.Write("Full Time (increment Hour): ");
            full_time.printTime();
            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);
            clockType cmp = new clockType(10,12,1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
            Console.Read();
        }
    }
}
