using DiscountCards.MementoClientInfo;
using Ninject.Modules;

namespace DiscountCards.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IClient>().To<Client>();
        }
    }
}
