using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerBusiness(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetbyId(int id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> GetByName(string name)
        {
            return _customerRepository.GetByName(name);
        }

        public void InactivateCustomer(int id)
        {
            _customerRepository.InactivateCustomer(id);
            return;
        }

        public Customer Insert(Customer customer)
        {
            return _customerRepository.Insert(customer);
        }

        public Customer Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
