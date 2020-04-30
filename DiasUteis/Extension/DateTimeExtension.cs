using System;
using System.Collections.Generic;
using WorkingDays.Exception;

namespace Extension
{
    static class DateTimeExtension
    {
        public static int CalculateWorkingDays(this DateTime thisObj, DateTime start, DateTime finish)
        {
            if (start > finish)
            {
                throw new DomainException("Date start cannot be bigger then date finish!");
            }
            else
            {
                HashSet<string> days = new HashSet<string>();
                days.Add("Monday");
                days.Add("Tuesday");
                days.Add("Wednesday");
                days.Add("Thursday");
                days.Add("Friday");

                TimeSpan duration = finish.Subtract(start);

                int count = 0;
                for (int i = 0; i <= duration.TotalDays; i++)
                {
                    DateTime NextDate = start.AddDays(i);
                    DayOfWeek dayOfWeek = NextDate.DayOfWeek;
                    if (days.Contains(dayOfWeek.ToString()))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
