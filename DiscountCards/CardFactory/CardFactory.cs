namespace DiscountCards.CardFactory
{
    public abstract class CardFactory
    {
        protected abstract Card MakeProduct();
        public Card  CreateProduct()
        {
            return this.MakeProduct();
        }

    }
}
