using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Ecommerce.Entity.IRepository
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        Customer Details(int id);
        void Delete(int id);
        Customer Edit(int id);
        void Edit(Customer customer);
        List<Customer> CustomerList();
    }
}
