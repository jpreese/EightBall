namespace PackageShipper.Rules
{
    public class LargeMessageRule : IPriceRule
    {
        public bool AppliesTo(string message)
        {
            return message.Length >= 5;
        }

        public int Apply(int currentPrice)
        {
            return currentPrice + 5;
        }
    }
}
