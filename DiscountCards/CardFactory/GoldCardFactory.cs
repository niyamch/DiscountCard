namespace DiscountCards.CardFactory
{
    class GoldCardFactory : CardFactory
    {
        protected override Card MakeProduct()
        {
            Card product = new GoldCard();
            return product;
        }
    }
}
