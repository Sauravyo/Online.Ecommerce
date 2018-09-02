using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Data.Context;
using Online.Ecommerce.Entity;
using Online.Ecommerce.Entity.IRepository;

namespace Online.Ecommerce.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        OnlineEcommerceContext _dbContext = new OnlineEcommerceContext();
        public void Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public List<Customer> CustomerList()
        {
            return _dbContext.Customers.ToList();
        }

        public void Delete(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }

        public Customer Details(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            return (customer);
        }

        public Customer Edit(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            return (customer);
        }

        public void Edit(Customer customer)
        {
            var customerinDb = _dbContext.Customers.Find(customer.ID);
            customerinDb.Name = customer.Name;
            customerinDb.State = customer.State;
            customerinDb.ZipCode = customer.ZipCode;
            customerinDb.Premium = customer.Premium;
            customerinDb.Active = customer.Active;
            customerinDb.Address = customer.Address;
            customerinDb.City = customer.City;

            _dbContext.SaveChanges();
        }
    }
}
