using System;

namespace PackageShipper
{
    public class PriceCalculator
    {
        public int Calculate(string messageToSend)
        {
            var price = messageToSend.Length;

            if(messageToSend.Length >= 5)
            {
                price += 5;
            }

            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                price += 100;
            }

            if(messageToSend.Contains("secret"))
            {
                price = 0;
            }

            return price;
        }
    }
}