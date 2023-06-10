using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03Lab
{
    class student
    {
        public student()
        {
            sname = "jill";
            matricMarks = 40.5F;
            fscMarks = 230F;
            ecatMarks = 200;
            aggregate = 63;


        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
    class student1
    {
        public student1(string n,float a,float b, float c, float d)
        {
           sname = n;
            matricMarks = a;
            fscMarks = b;
            ecatMarks = c;
            aggregate = d;


        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
    class student2
    {
        public student2()
        {
            Console.WriteLine("default constructor called");
        }
        public student2(student2 s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;


        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
    class clockType
    {
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h,int m)
        {
            hours = h;
            minutes = m;

        }
        public clockType(int h,int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public int hours;
        public int minutes;
        public int seconds;

        public void increamentHours()
        {
            hours++;
        }
        public void increamentMinutes()
        {
            minutes++;
        }
        public void increamentSeconds()
        {
            seconds++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);

        }
        public bool isEqual(int h,int m, int s)
        {
            if(hours==h && minutes==m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
