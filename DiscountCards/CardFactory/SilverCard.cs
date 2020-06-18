namespace DiscountCards.CardFactory
{
    public class SilverCard : Card
    {
        public string GetCardType()
        {
            return "Silver";
        }

        public double GetDiscountPercentage()
        {
            return 15;
        }
    }
}
