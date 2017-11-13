using Moq;
using PackageShipper.Rules;
using System;
using Xunit;

namespace PackageShipper.Tests
{
    public class MondayRuleTests
    {
        Mock<IDateTimeProvider> dateTimeProvider = new Mock<IDateTimeProvider>();

        [Fact]
        public void AppliesTo_WhenDayNotMonday_ReturnsFalse()
        {
            var mondayRule = CreateMondayRule();
            Assert.False(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        [Fact]
        public void AppliesTo_WhenDayMonday_ReturnsTrue()
        {
            var mondayRule = CreateMondayRule();
            dateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

            Assert.True(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        [Fact]
        public void AppliesTo_WhenDayNotMonday_ReturnsTrue()
        {
            var mondayRule = CreateMondayRule();
            dateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Sunday);

            Assert.False(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        private MondayRule CreateMondayRule()
        {
            return new MondayRule(dateTimeProvider.Object);
        }
    }
}
