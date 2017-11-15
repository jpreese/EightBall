using MessageSender.Rules;
using Xunit;
using Moq;

namespace MessageSender.Tests
{
    public class SecretRuleTests
    {
        [Fact]
        public void AppliesTo_NoSecretInMessage_ReturnsFalse()
        {
            var secretRule = CreateSecretRule();
            Assert.False(secretRule.AppliesTo("my awesome message"));
        }

        [Fact]
        public void AppliesTo_SecretInMessage_ReturnsTrue()
        {
            var secretRule = CreateSecretRule();
            Assert.True(secretRule.AppliesTo("super secret"));
        }

        [Fact]
        public void Apply_ByDefault_ReturnsZero()
        {
            var secretRule = CreateSecretRule();
            Assert.Equal(0, secretRule.Apply(It.IsAny<int>()));
        }

        private SecretRule CreateSecretRule()
        {
            return new SecretRule();
        }
    }
}
