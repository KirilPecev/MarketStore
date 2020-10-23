namespace MarketStore
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Owner: ");
            string owner = Console.ReadLine();

            Console.Write("Turnover: ");
            decimal turnover = decimal.Parse(Console.ReadLine());

            Console.Write("Purchase value: ");
            decimal purchaseValue = decimal.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 30));

            Card card = new GoldCard(owner, turnover);
            decimal discount = card.CalculateDiscount(purchaseValue);
            decimal total = purchaseValue - discount;

            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount rate: {card.DiscountRate:f1}%");
            Console.WriteLine($"Discount: ${discount:f2}");
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
