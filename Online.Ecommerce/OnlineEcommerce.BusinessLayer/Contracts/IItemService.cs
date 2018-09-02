using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;

namespace OnlineEcommerce.BusinessLayer.Contracts
{
    public interface IItemService
    {
        void Create(Item item);
        Item Detail(int id);
        void Delete(int id);
        Item Edit(int id);
        void Edit(Item item);
        List<Item> ItemList();

        
    }
}
