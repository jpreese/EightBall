using MessageSender.Rules;
using System;
using System.Collections.Generic;

namespace MessageSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message to send: ");
            var messageToSend = Console.ReadLine();

            var priceCalculator = new PriceCalculator(GetPriceRules());
            var price = priceCalculator.Calculate(messageToSend);
            Console.WriteLine($"Your total cost is: {price}");
        }

        /* Possible to use a DI container here, or reflection */
        private static IList<IPriceRule> GetPriceRules()
        {
            var rules = new List<IPriceRule>
            {
                new LargeMessageRule(),
                new MondayRule(new DateTimeProvider()),
                new SecretRule()
            };

            return rules;
        }
    }
}