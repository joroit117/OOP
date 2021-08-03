using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int Days { get; set; }

        public double GetDifferenceInDays(string date1, string date2)
        {
            string[] date1Holder = date1.Split(' ');
            int day1 = int.Parse(date1Holder[2]);
            int month1 = int.Parse(date1Holder[1]);
            int year1 = int.Parse(date1Holder[0]);

            string[] date2Holder = date2.Split(' ');
            int day2 = int.Parse(date2Holder[2]);
            int month2 = int.Parse(date2Holder[1]);
            int year2 = int.Parse(date2Holder[0]);

            DateTime firstDate = new DateTime(year1, month1, day1);
            DateTime secondDate = new DateTime(year2, month2, day2);
            if(firstDate > secondDate)
            {
                return (firstDate - secondDate).TotalDays;
            }
            else
            {
                return (secondDate - firstDate).TotalDays;
            }
            
        }
    }
}
