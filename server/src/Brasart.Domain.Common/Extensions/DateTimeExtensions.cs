using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Brasart.Domain.Common.ValueObjects;

namespace Brasart.Domain.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime date)
            => date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;

        public static bool IsWorkDay(this DateTime date)
           => !IsWeekend(date);

        public static DateTime Create(int day, int month, int year)
            => new DateTime(year, month, day);

        public static DateTimeVo ToDateTimeVo(this DateTime date)
            => new DateTimeVo(date);

        public static DateTime OnlyDate(this DateTime date)
            => new DateTime(date.Year, date.Month, date.Day);

        public static bool Exists(this List<DateTime> dates, DateTime date)
            => dates.Any(d => d.Year == date.Year && d.Month == date.Month && d.Day == date.Day);

        public static DateTime FirstDayWeekGregorianCalendar(this DateTime date)
        {
            var calendar = new GregorianCalendar();

            var dayWeek = calendar.GetDayOfWeek(date);
            var firsDayWeek = date.AddDays((int)dayWeek * -1);

            return firsDayWeek;
        }

        public static DateTime LastDayWeekGregorianCalendar(this DateTime date)
        {
            var firsDayWeek = date.FirstDayWeekGregorianCalendar();
            var lastWeek = firsDayWeek.AddDays(6);

            return lastWeek;
        }




    }
}
