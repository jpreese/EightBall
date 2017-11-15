namespace MessageSender.Rules
{
    interface IPriceRule
    {
        bool AppliesTo(string message);
        int Apply(int currentPrice);
    }
}
