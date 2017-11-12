using System;

namespace PackageShipper
{
    public class ShippingApplication
    {
        private readonly ICalculator _priceCalculator;

        public ShippingApplication(ICalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
        }

        public void Ship(string message)
        {
            var price = _priceCalculator.Calculate(message);
            Console.WriteLine($"Your shipped message cost: {price}");
        }
    }
}