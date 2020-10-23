namespace MarketStore
{
    public class BronzeCard : Card
    {
        private const double InitialDiscountRate = 0;

        public BronzeCard(string owner, decimal turnover)
            : base(owner, turnover, InitialDiscountRate)
        { }

        protected override void CalculateDiscountRate(decimal purchaseValue)
        {
            if (this.Turnover > 100 && this.Turnover <= 300)
            {
                this.DiscountRate = 1;
            }

            if (this.Turnover > 300)
            {
                this.DiscountRate = 2.5;
            }
        }
    }
}
