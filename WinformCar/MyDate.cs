using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformCar
{
    class MyDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public string PrintInfo()
        {
            return ($"{Year}-{Month}-{Day}");
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - Year;
        }

        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
