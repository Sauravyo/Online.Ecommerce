using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerce.Entity.IRepository
{
    public interface IItemRepository
    {
        void Add(Item item);
        Item Details(int id);
        void Delete(int id);
        Item Edit(int id);
        void Edit(Item item);
        List<Item> ItemList();
    }
}
