using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class Date
    {
        public int _year;
        public int _month;
        public int _day;

        public Date(int year, int month, int day)
        {
            #region constructor
            this._year = year;
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day, month);
            #endregion
        }



        #region tostring
        public override string ToString()
        {
            return $"{_year:0000}  /  {_month:00} /  {_day:00}";
        }
        #endregion

        private int ValidateDay(int day, int month)
        {
            if (month == 2 && day >= 1 && day <= 28)
            {
                return day;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11 && day >= 1 && day <= 30)
            { return day; }

            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 && day >= 1 && day <= 31)
            { return day; }

            throw new DayException("the day is incorrect");
        }
        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MotnhException("the month is incorrect");
        }
        private int validateYear(int year)
        {
            if (year >= 1900 && year <= 9999) {
            return year;}

            throw new YearException("the year is invalidar");
        }
    }
}
