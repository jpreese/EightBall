using Moq;
using MessageSender.Rules;
using System;
using Xunit;

namespace MessageSender.Tests
{
    public class MondayRuleTests
    {
        private readonly Mock<IDateTimeProvider> _dateTimeProvider;

        public MondayRuleTests()
        {
            _dateTimeProvider = new Mock<IDateTimeProvider>();
        }

        [Fact]
        public void AppliesTo_WhenDayMonday_ReturnsTrue()
        {
            var mondayRule = CreateMondayRule();
            _dateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

            Assert.True(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        [Fact]
        public void AppliesTo_WhenDayNotMonday_ReturnsFalse()
        {
            var mondayRule = CreateMondayRule();
            _dateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Sunday);

            Assert.False(mondayRule.AppliesTo(It.IsAny<string>()));
        }

        [Fact]
        public void Apply_ByDefault_Adds100()
        {
            var mondayRule = CreateMondayRule();
            Assert.Equal(It.IsAny<int>() + 100, mondayRule.Apply(It.IsAny<int>()));
        }

        private MondayRule CreateMondayRule()
        {
            return new MondayRule(_dateTimeProvider.Object);
        }
    }
}
