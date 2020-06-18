using System;
using DiscountCards.CardFactory;

namespace DiscountCards.MementoClientInfo
{
    public class Client : IClient
    {
        string fName;
        string lName;
        string pin;
        Card card;
        private DateTime lastEdited;

        public string FName 
        {
            get { return fName; }
            set
            {
                fName = value;
                SetLastEdited();
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
                SetLastEdited();
            }
        }
        public Card Card
        {
            get
            {
                return card;
            }
            set
            {
                card = value;
                SetLastEdited();
            }
        }
        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
                SetLastEdited();
            }
        }

        public Client()
        {
            SetLastEdited();
        }

        private void SetLastEdited()
        {
            lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(fName, lName, pin, card, lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            fName = memento.mFName;
            lName = memento.mLName;
            card = memento.mCard;
            lastEdited = memento.mLastEdited;
        }

        public void ShowClientInfo()
        {
            Console.WriteLine(
                "{0} {1} ( Pin:{2} ) - Card type: {3}, discount: {4}%.", FName, LName, Pin, card.GetCardType(), card.GetDiscountPercentage());
        }
    }
}
