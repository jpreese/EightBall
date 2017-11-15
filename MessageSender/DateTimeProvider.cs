using System;

namespace MessageSender
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DayOfWeek DayOfWeek()
        {
            return DateTime.Now.DayOfWeek;
        }
    }
}
