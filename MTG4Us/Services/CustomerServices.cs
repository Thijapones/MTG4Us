using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerBusiness _customerBusiness;
        public CustomerServices(ICustomerBusiness customerBusines)
        {
            _customerBusiness = customerBusines;
        }

        public void ActivateCustomer(int id)
        {
            _customerBusiness.ActivateCustomer(id);
            return;
        }

        public List<Customer> GetAll()
        {
            return _customerBusiness.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerBusiness.GetById(id);
        }

        public List<Customer> GetByName(string name)
        {
            return _customerBusiness.GetByName(name);
        }

        public void InactivateCustomer(int id)
        {
            _customerBusiness.InactivateCustomer(id);
            return;
        }

        public Customer Insert(Customer customer)
        {
            return _customerBusiness.Insert(customer);
        }

        public Customer Update(Customer customer)
        {
            return _customerBusiness.Update(customer);
        }
    }
}
