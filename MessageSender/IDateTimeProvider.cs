using System;

namespace MessageSender
{
    public interface IDateTimeProvider
    {
        DayOfWeek DayOfWeek();
    }
}