using DiscountCards.CardFactory;
using DiscountCards.MementoClientInfo;
using Ninject;
using System.Reflection;

namespace DiscountCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ninject
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var client1 = kernel.Get<IClient>();
            var client2 = kernel.Get<IClient>();

            //Card Factory
            GoldCardFactory goldCard = new GoldCardFactory();
            client1.FName = "Jimmy";
            client1.LName = "Johnes";
            client1.Pin = "7y834874";
            client1.Card = goldCard.CreateProduct();

            SilverCardFactory silverCard = new SilverCardFactory();
            client2.FName = "Elma";
            client2.LName = "Stephens";
            client2.Pin = "87d649d7";
            client2.Card = silverCard.CreateProduct();

            client1.ShowClientInfo();
            client2.ShowClientInfo();

            //Memento Client Info
            Caretaker history = new Caretaker();
            history.Memento = client1.CreateUndo();
            BronzeCardFactory bronzeCard = new BronzeCardFactory();
            client1.Card = bronzeCard.CreateProduct();

            client1.ShowClientInfo();

            client1.Card = goldCard.CreateProduct();

            client1.ShowClientInfo();
        }
    }
}
