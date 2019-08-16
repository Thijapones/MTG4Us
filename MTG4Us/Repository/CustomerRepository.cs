using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration config, ILogger<Repository<Customer>> logger) : base(config, logger)
        {

        }

        public List<Customer> GetByName(string name)
        {
            var query = $"select name,mobilephone,email" +
                        $"from customers.customer where name like @name";
            var parameters = new DynamicParameters();
            parameters.Add("@name", "%" + name + "%");
            return ExecuteQuery(query, parameters);
        }
    }
}
