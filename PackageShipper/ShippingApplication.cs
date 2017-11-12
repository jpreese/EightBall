using System;

namespace PackageShipper
{
    internal class ShippingApplication
    {
        public ShippingApplication()
        {
        }

        public void Ship(string message)
        {
            var priceCalculator = new PriceCalculator();
            var price = priceCalculator.Calculate(message);

            Console.WriteLine($"Your shipped message cost: {price}");
        }
    }
}