using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online.Ecommerce.Entity
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string ItemNumber { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }
        public bool Active { get; set; }


    }
}
