using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerce.Domain
{
    class SalesOrderItem
    {
        public int ID { get; set; }

        //Foreign Key Quote Summary

        //Foreign Key Item
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}
