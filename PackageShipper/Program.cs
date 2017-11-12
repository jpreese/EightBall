using System;

namespace PackageShipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message to send: ");
            var messageToSend = Console.ReadLine();

            var shippingApplication = new ShippingApplication();
            shippingApplication.Ship(messageToSend);
        }
    }
}