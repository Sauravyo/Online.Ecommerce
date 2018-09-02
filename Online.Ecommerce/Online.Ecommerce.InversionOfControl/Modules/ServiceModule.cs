using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Online.Ecommerce.Entity.IRepository;
using Online.Ecommerce.Data.Repositories;

namespace Online.Ecommerce.InversionOfControl.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
           
            Bind<IItemRepository>().To<ItemRepository>();
        }
    }
}
