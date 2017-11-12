using Moq;
using PackageShipper.Rules;
using System;
using Xunit;

namespace PackageShipper.Tests
{
    public class MondayRuleTests
    {
        [Fact]
        public void AppliesTo_WhenDayNotMonday_ReturnsFalse()
        {
            var mondayRule = CreateMondayRule(new Mock<IDateTimeProvider>());
            Assert.False(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        [Fact]
        public void AppliesTo_WhenDayMonday_ReturnsTrue()
        {
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            var mondayRule = CreateMondayRule(dateTimeProvider);
            dateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

            Assert.True(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        private MondayRule CreateMondayRule(Mock<IDateTimeProvider> dateTimeProvider)
        {
            return new MondayRule(dateTimeProvider.Object);
        }
    }
}
