using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;

namespace OnlineEcommerce.BusinessLayer
{
    class OrderLine
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
