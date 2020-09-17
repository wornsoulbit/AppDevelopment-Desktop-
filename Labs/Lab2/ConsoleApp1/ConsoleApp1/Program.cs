using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(59, 20, 3, 2, 3, 2010);
            time.DisplayTimeDate();
            time.DisplayTime();
            time.DisplayDay();
        }
    }

    class Date {
        protected int day;
        protected int month;
        protected int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public virtual void DisplayDay()
        {
            Console.WriteLine(day + ":" + month + ":" + year);
        }
    }

    class Time : Date {
        protected int sec;
        protected int min;
        protected int hr;

        public Time(int sec, int min, int hr, int day, int month, int year) : base(day, month, year)
        {
            this.sec = sec;
            this.min = min;
            this.hr = hr;
        }

        public virtual void DisplayTime()
        {
            Console.WriteLine(hr + ":" + min + ":" + sec);
        }
    }

    class DateTime : Time {
        public DateTime(int sec, int min, int hr, int day, int month, int year) : base(day, month, year, sec, min, hr)
        {

        }

        public override void DisplayTime()
        {
            Console.Write("the time is: ");
            base.DisplayTime();
        }

        public override void DisplayDay()
        {
            Console.Write("the day is: ");
            base.DisplayDay();
        }

        public void DisplayTimeDate()
        {
            DisplayDay();
            DisplayTime();
        }
    }

}
