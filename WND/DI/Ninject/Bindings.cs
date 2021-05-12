using Ninject.Modules;
using Ninject;
using WND.Data;
using System.Data.Entity;


public class Bindings : NinjectModule
{
    public override void Load()
    {
        //Bind<ITaxiDbContext>().To<TaxiDbContext>();
    }
}