using System;
using System.Collections.Generic;
using Brasart.Domain.Common.Extensions;

namespace Brasart.Domain.Common.ValueObjects
{
    public class DateTimeVo : ValueObject
    {

        #region Fields
        private readonly DateTime _dateTime;
        private readonly DateTime _onlyDate;


        #endregion

        #region Properties

        public static DateTime Today => DateTime.Today;

        public static DateTimeOffset UtcNow => DateTimeOffset.UtcNow;

        public DateTime Date => _onlyDate;

        public long Ticks => _dateTime.Ticks;

        #endregion

        #region Constructors
        public DateTimeVo(int day, int month, int year)
            : this(new DateTime(year, month, day))
        { }

        public DateTimeVo(DateTime dateTime)
        {
            _dateTime = dateTime;
            _onlyDate = new DateTime(_dateTime.Year, _dateTime.Month, _dateTime.Day);

        }



        public static DateTimeVo Now()
           => new(DateTime.Now);

        public static DateTimeVo Create(int day, int month, int year)
            => new(day, month, year);

        public static DateTimeVo Create(int day, int month)
           => new(day, month, Now().Date.Year);

        #endregion

        #region Methods
        public bool IsNotValid() => !IsValid();

        public override bool IsValid() => !_dateTime.Equals(DateTime.MinValue);

        public static DateTime operator +(DateTimeVo self, int days)
            => self.Date.AddDays(days);

        public static DateTime operator -(DateTimeVo self, int days)
             => self.Date.AddDays(days * -1);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return null;
        }

        public DateTimeVo NextUseWorkDay(List<DateTime> holidays, bool workDays)
        {
            var nextDateTime = new DateTimeVo(_dateTime.Date.AddDays(1));

            if (holidays.Exists(nextDateTime.Date) || workDays && nextDateTime.Date.IsWeekend() )
                return nextDateTime.NextUseWorkDay(holidays, workDays);
                
            return nextDateTime;


        }


        #endregion

    }
}
