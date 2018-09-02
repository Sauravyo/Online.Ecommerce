using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online.Ecommerce.Entity;
using OnlineEcommerce.BusinessLayer.Contracts;
using Online.Ecommerce.Entity.IRepository;

namespace OnlineEcommerce.BusinessLayer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Create(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public List<Customer> CustomerList()
        {
            return _customerRepository.CustomerList();
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public Customer Details(int id)
        {
            var customer=_customerRepository.Details(id);
            return (customer);
        }

        public Customer Edit(int id)
        {
            var customer = _customerRepository.Edit(id);
            return (customer);
        }

        public void Edit(Customer customer)
        {
            _customerRepository.Edit(customer);
        }
    }
}
