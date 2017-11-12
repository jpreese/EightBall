using System;

namespace PackageShipper
{
    public interface IDateTimeProvider
    {
        DayOfWeek DayOfWeek();
    }
}