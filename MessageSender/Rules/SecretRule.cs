namespace MessageSender.Rules
{
    public class SecretRule : IPriceRule
    {
        public bool AppliesTo(string message)
        {
            return message.Contains("secret");
        }

        public int Apply(int currentPrice)
        {
            return 0;
        }
    }
}
