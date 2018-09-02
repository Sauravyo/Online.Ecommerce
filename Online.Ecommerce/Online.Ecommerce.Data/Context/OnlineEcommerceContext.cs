using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;


namespace Online.Ecommerce.Data.Context
{
    public class OnlineEcommerceContext : DbContext
    {
        public OnlineEcommerceContext() : base("OnlineEcommerceContext")
        {

        }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }
        public virtual DbSet<SalesOrderSummary> SalesOrderSummarys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<SalesOrderItem>().ToTable("SalesOrderItems");
            modelBuilder.Entity<SalesOrderSummary>().ToTable("SalesOrderSummaries");

        }

        //public System.Data.Entity.DbSet<OnlineEcommerce.Business.Models.SaleOrderVM> SaleOrderVMs { get; set; }
    }
   
}
