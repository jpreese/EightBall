using PackageShipper.Rules;
using System.Collections.Generic;

namespace PackageShipper
{
    internal class PriceCalculator : ICalculator
    {
        private readonly List<IPriceRule> _priceRules = new List<IPriceRule>();

        public PriceCalculator()
        {
            _priceRules.Add(new SecretRule());
            _priceRules.Add(new LargeMessageRule());
            _priceRules.Add(new MondayRule(new DateTimeProvider()));
        }

        public int Calculate(string message)
        {
            var price = message.Length;

            foreach(var rule in _priceRules)
            {
                if(rule.AppliesTo(message))
                {
                    price = rule.Apply(price);
                }
            }

            return price;
        }
    }
}