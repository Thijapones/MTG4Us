using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> GetByName(string name);

        void InactivateCustomer(int id);
    }
}
