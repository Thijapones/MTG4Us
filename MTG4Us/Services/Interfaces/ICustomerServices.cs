using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICustomerServices
    {
        Customer Insert(Customer customer);

        Customer GetById(int id);

        List<Customer> GetAll();

        List<Customer> GetByName(string name);

        Customer Update(Customer customer);

        void InactivateCustomer(int id);

        void ActivateCustomer(int id);
    }
}
