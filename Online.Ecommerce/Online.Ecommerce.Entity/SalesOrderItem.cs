using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerce.Entity
{
     public class SalesOrderItem
    {
        public int ID { get; set; }

        //Foreign Key Quote 
        public int SalesOrderSummaryID { get; set; }
        public virtual SalesOrderSummary SalesOrderSummary { get; set; }

        //Foreign Key Item
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}
