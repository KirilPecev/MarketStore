namespace MarketStore
{
    public abstract class Card
    {
        protected Card(string owner, decimal turnover, double discountRate)
        {
            this.Owner = owner;
            this.Turnover = turnover;
            this.DiscountRate = discountRate;
        }

        public string Owner { get; private set; }

        public decimal Turnover { get; private set; }

        public double DiscountRate { get; protected set; }

        public decimal CalculateDiscount(decimal purchaseValue)
        {
            this.CalculateDiscountRate(purchaseValue);

            return purchaseValue * (decimal) this.DiscountRate / 100;
        }

        protected abstract void CalculateDiscountRate(decimal purchaseValue);
    }
}
