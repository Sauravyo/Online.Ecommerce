using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Online.Ecommerce.Entity;

namespace OnlineEcommerce.Business.Models
{
    public class SaleOrderVM
    {
        public IEnumerable< Item> ItemVm { get; set; }
        public SalesOrderSummary SaleorderVm{ get; set; }
        public IEnumerable<Customer> CustomerVm { get; set; }

        
    }
}