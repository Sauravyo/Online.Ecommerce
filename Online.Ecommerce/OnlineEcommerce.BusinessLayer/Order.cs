using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;

namespace OnlineEcommerce.BusinessLayer
{
    class Order
    {
        private List<OrderLine> orderlist = new List<OrderLine>();
        public void AddItem(Item item, int quantity)
        {
            OrderLine line = orderlist.Where(i => i.Item == item).FirstOrDefault();
            if (line == null)
            {
                orderlist.Add(new OrderLine { Item = item, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveOrder(Item item)
        {
            orderlist.RemoveAll(i=>i.Item==item);
        }

        public decimal CalculateOrderTotal()
        {
            return orderlist.Sum(i => i.Item.Price * i.Quantity);
        }

        public IEnumerable<OrderLine> Orders
        { get { return orderlist; } }

        public void Clear()
        {
            orderlist.Clear();
        }
    }
}
