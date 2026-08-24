using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf11th
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public static void DateUT()
        {
            //Date d1 = new Date(12, 12, 1212);
            //Date now = new Date();
            //Console.WriteLine(now.CompareTo(d1));
            //Date d2 = new Date(1, 1, 2010);
            //Date d3 = new Date(1, 1, 2000);
            //Date d4 = new Date(1, 1, 1900);
            //Date d5 = new Date(1, 1, 2024);
            //Console.WriteLine(d2.LeapYear());
            //Console.WriteLine(d3.LeapYear());
            //Console.WriteLine(d4.LeapYear());
            //Console.WriteLine(d5.LeapYear());
            //Date[] dates = {now, d1, d2, d3, d4, d5};
            //SortDates(dates);
            //for (int i = 0; i < dates.Length; i++)
            //{
            //    Console.WriteLine(dates[i]);
            //}
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Date() : this(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)
        {

        }

        public Date(Date d) : this(d.GetDay(), d.GetMonth(), d.GetYear())
        {

        }

        public int GetYear()
        {
            return this.year;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public int GetDay()
        {
            return this.day;
        }

        public void SetYear(int yearToSet)
        {
            if (yearToSet >= 1000 && yearToSet <= 9999)
            {
                this.year = yearToSet;
            }
        }

        public void SetMonth(int monthToSet)
        {
            if (monthToSet >= 1 && monthToSet <= 12)
            {
                this.month = monthToSet;
            }
        }

        public void SetDay(int dayToSet)
        {
            if (dayToSet >= 1 && dayToSet <= 31)
            {
                this.day = dayToSet;
            }
        }

        public int CompareTo(Date other)
        {
            if (this.year > other.GetYear())
            {
                return 1;
            }
            else if (this.year < other.GetYear())
            {
                return -1;
            }
            else
            {
                if (this.month > other.GetMonth())
                {
                    return 1;
                }
                else if (this.month < other.GetMonth())
                {
                    return -1;
                }
                else
                {
                    if (this.day > other.GetDay())
                    {
                        return 1;
                    }
                    if (this.day < other.GetDay())
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public override string ToString()
        {
            string str = $"{this.GetDay()}.{this.GetMonth()}.{this.GetYear()}";
            return str;
        }

        public bool LeapYear()
        {
            bool leap = false;
            if (this.GetYear() % 4 == 0)
            {
                leap = true;
            }
            if (this.GetYear() % 100 == 0)
            {
                if (this.GetYear() % 400 == 0)
                {
                    leap = true;
                }
                else
                {
                    leap = false;
                }
            }
            return leap;
        }

        public static void SortDates(Date[] dates)
        {
            Date temp = new Date();
            for (int i = 0; i < dates.Length; i++)
            {
                for (int j = i; j < dates.Length; j++)
                {
                    if (dates[i].CompareTo(dates[j]) == 1)
                    {
                        temp = dates[i];
                        dates[i] = dates[j];
                        dates[j] = temp;
                    }
                }
            }
        }
    }
}
