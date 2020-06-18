namespace DiscountCards.CardFactory
{
    class BronzeCardFactory : CardFactory
    {
        protected override Card MakeProduct()
        {
            Card product = new BronzeCard();
            return product;
        }
    }
}
