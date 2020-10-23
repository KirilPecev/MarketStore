namespace MarketStore
{
    public class GoldCard : Card
    {
        private const double InitialDiscountRate = 2;

        public GoldCard(string owner, decimal turnover)
            : base(owner, turnover, InitialDiscountRate)
        { }

        protected override void CalculateDiscountRate(decimal purchaseValue)
        {
            int valueIncrease = (int)(this.Turnover / 100);
            this.DiscountRate += valueIncrease;

            if (this.DiscountRate > 10)
            {
                this.DiscountRate = 10;
            }
        }
    }
}
