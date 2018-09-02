using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEcommerce.BusinessLayer.Contracts;
using Online.Ecommerce.Entity;
using Online.Ecommerce.Entity.IRepository;


namespace OnlineEcommerce.BusinessLayer
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        //Constructor based dependency injection
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public void Create(Item item)
        {
            _itemRepository.Add(item);
        }

        public void Delete(int id)
        {
            _itemRepository.Delete(id);

        }

        public Item Detail(int id)
        {
            Item item = _itemRepository.Details(id);
            return (item);
        }

        public Item Edit(int id)
        {
            var item = _itemRepository.Edit(id);
            return (item);
        }

        public void Edit(Item item)
        {
            _itemRepository.Edit(item);
        }

        public List<Item> ItemList()
        {
            return _itemRepository.ItemList();
        }
    }
}
