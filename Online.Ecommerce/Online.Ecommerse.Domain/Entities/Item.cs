using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerse.Domain
{
    class Item
    {
        public int ID { get; set; }
        public string ItemNumber { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public bool Active { get; set; }
    }
}
