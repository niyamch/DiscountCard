namespace DiscountCards.CardFactory
{
    public class SilverCardFactory : CardFactory
    {
        protected override Card MakeProduct()
        {
            Card product = new SilverCard();
            return product;
        }
    }
}
