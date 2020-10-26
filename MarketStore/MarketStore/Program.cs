namespace MarketStore
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Owner: ");
            string owner = Console.ReadLine();

            try
            {
                Console.Write("Turnover: ");
                decimal turnover = decimal.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("Purchase value: ");
                decimal purchaseValue = decimal.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine(new string('-', 30));

                Card card = new GoldCard(owner, turnover);
                decimal discount = card.CalculateDiscount(purchaseValue);
                decimal total = purchaseValue - discount;

                Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
                Console.WriteLine($"Discount rate: {card.DiscountRate:f1}%");
                Console.WriteLine($"Discount: ${discount:f2}");
                Console.WriteLine($"Total: ${total:f2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the correct values!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid operation! Please enter the correct values!");
            }
            catch (IOException)
            {
                Console.WriteLine("Output exception!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please contact with the admin!");
            }
        }
    }
}
