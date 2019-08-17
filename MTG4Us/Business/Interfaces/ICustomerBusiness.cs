using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICustomerBusiness
    {
        /// <summary>
        /// A customer cannot be removed. 
        /// Instead, its status should be set to Inactive.
        /// </summary>
        /// <returns></returns>
        Customer Insert(Customer customer);

        Customer GetById(int id);

        List<Customer> GetAll();

        List<Customer> GetByName(string name);

        Customer Update(Customer customer);

        void InactivateCustomer(int id);

        void ActivateCustomer(int id);
    }
}
