using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BagRepository : Repository<Bag>, IBagRepository
    {
        public BagRepository(IConfiguration config, ILogger<Repository<Bag>> logger) : base(config, logger)
        {
        }

        public List<Bag> GetbyCustomer(int custid)
        {
            var query = $"select *" +
                        $"from views.vwbag where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            return ExecuteQuery(query, parameters);
        }

        public List<Bag> GetbyOwner(int ownerid)
        {
            var query = $"select *" +
                        $"from views.vwbag where ownerid=@ownerid";
            var parameters = new DynamicParameters();
            parameters.Add("@ownerid", ownerid);
            return ExecuteQuery(query, parameters);
        }
    }
}
