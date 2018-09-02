using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;


namespace OnlineEcommerce.BusinessLayer.Contracts
{
    public interface ICustomerService
    {
        void Create(Customer customer);
        Customer Details(int id);
        void Delete(int id);
        Customer Edit(int id);
        void Edit(Customer customer);
        List<Customer> CustomerList();
    }
}
