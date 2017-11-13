using System;

namespace PackageShipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message to send: ");
            var messageToSend = Console.ReadLine();

            var priceCalculator = new PriceCalculator();
            var price = priceCalculator.Calculate(messageToSend);

            Console.WriteLine($"Your calculated price is: {price}");
        }
    }
}
