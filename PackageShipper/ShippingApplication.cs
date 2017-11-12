using System;

namespace PackageShipper
{
    public class ShippingApplication
    {
        public void Ship(string messageToSend)
        {
            var priceCalculator = new PriceCalculator();
            var price = priceCalculator.Calculate(messageToSend);

            Console.WriteLine($"Your message has been shipped! It costed: {price}");
        }
    }
}