using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2019, 2, 18);

            for (int i = 0; i < 15; i++)
            {
                date = date.AddDays(-i * i);
                Console.WriteLine("{0} was {1}.", date.ToShortDateString(), GetDaysAgo(date));
            }
        }
        static string GetDaysAgo(DateTime date)
        {
            // We are hard coding the start date for consistent output.
            // In reality you would probably use DateTime.Now
            DateTime todayDate = new DateTime(2019, 2, 18);

            double daysAgo = todayDate.Subtract(date.Date).Days;
            int weeksAgo = (int)(daysAgo / 7.0);
            int monthsAgo = (int)(daysAgo / 30.0);
            int yearsAgo = (int)(daysAgo / 365.0);

            // TODO: implement this method
            if (daysAgo == 0)
            {
                return "Today";
            }
            if (daysAgo == 1)
            {
                return "Yesterday";
            }
            if (daysAgo < 14)
            {
                return String.Format("{0} {1} ago", daysAgo, GetPluralized("day", (int)daysAgo));
            }
            if (weeksAgo < 6)
            {
                return String.Format("{0} {1} ago", weeksAgo, GetPluralized("week", weeksAgo));
            }
            if (monthsAgo < 12)
            {
                return String.Format("{0} {1} ago", monthsAgo, GetPluralized("month", monthsAgo));
            }
            else
            {
                return String.Format("{0} {1} ago", yearsAgo, GetPluralized("year", yearsAgo));
            }
        }

       
        static string GetPluralized(string word, int count)
        {
            return count != 1 ? word + "s" : word;
        }

    }
}
