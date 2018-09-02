using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Data.Context;
using Online.Ecommerce.Entity;
using Online.Ecommerce.Entity.IRepository;
using System.Data.Entity;

namespace Online.Ecommerce.Data.Repositories
{
    public class ItemRepository: IItemRepository
    {
        OnlineEcommerceContext _dbContext = new OnlineEcommerceContext();
        public void Add(Item item)
        {
            //_dbContext.Items.Add(item);
            _dbContext.Entry(item).State = EntityState.Added;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _dbContext.Items.Find(id);
            _dbContext.Items.Remove(item);
            _dbContext.SaveChanges();
        }

        public Item Details(int id)
        {
           
            Item item = _dbContext.Items.Find(id); 
            return (item);
        }

        public Item Edit(int id)
        {
            var item = _dbContext.Items.Find(id);
            
             return (item);
        }

        public void Edit(Item item)
        {
            var ItemInDB = _dbContext.Items.Find(item.ID);
            ItemInDB.ItemNumber = item.ItemNumber;
            ItemInDB.Price = item.Price;
            ItemInDB.Active = item.Active;
            ItemInDB.QuantityAvailable = item.QuantityAvailable;

            _dbContext.SaveChanges();
        }

        public List<Item> ItemList()
        {
           return  _dbContext.Items.ToList();

        }
    }
}
