namespace MarketStore
{
    public class SilverCard : Card
    {
        private const double InitialDiscountRate = 2;

        public SilverCard(string owner, decimal turnover)
            : base(owner, turnover, InitialDiscountRate)
        { }

        protected override void CalculateDiscountRate(decimal purchaseValue)
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = 3.5;
            }
        }
    }
}
