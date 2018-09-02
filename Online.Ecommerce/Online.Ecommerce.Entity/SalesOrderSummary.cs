using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerce.Entity
{
     public class SalesOrderSummary
    {
        public int ID { get; set; }

        //Foreign Key Customer Table
        public int CustomerID { get; set; }
        public virtual Customer Customr { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal ItemTotal { get; set; }

        public decimal OrderTotal { get; set; }

        public bool PremiumDiscount { get; set; }
        //Flag 1 open, 2 closed 3 cancelled
        //public int Flag { get; set; }
                    
    }
}
