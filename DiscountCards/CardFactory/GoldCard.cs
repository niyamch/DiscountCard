namespace DiscountCards.CardFactory
{
    public class GoldCard : Card
    {
        public string GetCardType()
        {
            return "Gold";
        }

        public double GetDiscountPercentage()
        {
            return 25;
        }
    }
}
