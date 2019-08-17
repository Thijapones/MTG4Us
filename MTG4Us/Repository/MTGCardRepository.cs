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
    public class MTGCardRepository : Repository<MTGCard>, IMTGCardRepository
    {
        public MTGCardRepository(IConfiguration config, ILogger<Repository<MTGCard>> logger) : base(config, logger)
        {

        }

        public List<MTGCard> GetByName(string name)
        {
            var query = $"select * " +
                        $"from items.mtgcard where name like @name";
            var parameters = new DynamicParameters();
            parameters.Add("@name", "%" + name + "%");
            return ExecuteQuery(query, parameters);
        }

        public List<MTGCard> GetBySet(string set)
        {
            var query = $"select * " +
                        $"from items.mtgcard where [set] like @set";
            var parameters = new DynamicParameters();
            parameters.Add("@set", "%" + set + "%");
            return ExecuteQuery(query, parameters);
        }

        public List<MTGCard> GetBySetCode(string setcode)
        {
            var query = $"select * " +
                        $"from items.mtgcard where setcode like @setcode";
            var parameters = new DynamicParameters();
            parameters.Add("@setcode", "%" + setcode + "%");
            return ExecuteQuery(query, parameters);
        }

        public List<MTGCard> GetByMTGId(int mtgid)
        {
            var query = $"select * " +
                        $"from items.mtgcard where mtgid=@mtgid";
            var parameters = new DynamicParameters();
            parameters.Add("@mtgid", mtgid);
            return ExecuteQuery(query, parameters);
        }
    }
}
