using DiscountCards.CardFactory;

namespace DiscountCards.MementoClientInfo
{
    interface IClient
    {
        string FName { get; set; }
        string LName { get; set; }
        string Pin { get; set; }
        Card Card { get; set; }
        Memento CreateUndo();
        void RestoreFromUndo(Memento memento);
        void ShowClientInfo();
    }
}
