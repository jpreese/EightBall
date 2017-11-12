using System;

namespace PackageShipper
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DayOfWeek DayOfWeek()
        {
            return DateTime.Now.DayOfWeek;
        }
    }
}
