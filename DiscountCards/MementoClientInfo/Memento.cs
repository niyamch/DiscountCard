using DiscountCards.CardFactory;
using System;

namespace DiscountCards.MementoClientInfo
{
    public class Memento
    {
        public string mFName { get; set; }
        public string mLName { get; set; }
        public string mPin { get; set; }
        public Card mCard { get; set; }
        public DateTime mLastEdited { get; set; }

        public Memento(string _fname, string _lname,string _pin, Card _card, DateTime _lastedited)
        {
            mFName = _fname;
            mLName = _lname;
            mPin = _pin;
            mCard = _card;
            mLastEdited = _lastedited;
        }
    }
}
