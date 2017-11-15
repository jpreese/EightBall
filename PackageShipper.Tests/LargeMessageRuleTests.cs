using Moq;
using PackageShipper.Rules;
using Xunit;

namespace PackageShipper.Tests
{
    public class LargeMessageRuleTests
    {
        [Fact]
        public void AppliesTo_SmallMessage_ReturnsFalse()
        {
            var largeMessageRule = CreateLargeMessageRule();
            Assert.False(largeMessageRule.AppliesTo(string.Empty));
        }

        [Fact]
        public void AppliesTo_LargeMessage_ReturnsFalse()
        {
            var largeMessageRule = CreateLargeMessageRule();
            Assert.True(largeMessageRule.AppliesTo(string.Empty.PadLeft(5)));
        }

        [Fact]
        public void Apply_ByDefault_AddsFive()
        {
            var largeMessageRule = CreateLargeMessageRule();
            Assert.Equal(It.IsAny<int>() + 5, largeMessageRule.Apply(It.IsAny<int>()));
        }

        private LargeMessageRule CreateLargeMessageRule()
        {
            return new LargeMessageRule();
        }
    }
}
