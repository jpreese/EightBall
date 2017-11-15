using System;

namespace MessageSender.Rules
{
    public class MondayRule : IPriceRule
    {
        IDateTimeProvider _dateTimeProvider;

        public MondayRule(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public bool AppliesTo(string message)
        {
            return _dateTimeProvider.DayOfWeek() == DayOfWeek.Monday;
        }

        public int Apply(int currentPrice)
        {
            return currentPrice + 100;
        }
    }
}
