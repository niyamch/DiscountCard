namespace DiscountCards.CardFactory
{
    public class BronzeCard : Card
    {
        public string GetCardType()
        {
            return "Bronze";
        }

        public double GetDiscountPercentage()
        {
            return 5;
        }
    }
}
