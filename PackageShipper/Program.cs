using PackageShipper.Rules;
using System;
using System.Collections.Generic;

namespace PackageShipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message to send: ");
            var messageToSend = Console.ReadLine();

            var shippingApplication = new ShippingApplication(new PriceCalculator(GetPriceRules()));

            shippingApplication.Ship(messageToSend);
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