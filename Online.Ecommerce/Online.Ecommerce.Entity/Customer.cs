using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online.Ecommerce.Entity
{
    
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
                
        public string ZipCode { get; set; }
        public bool Premium { get; set; }
        public bool Active { get; set; }
    }
}
