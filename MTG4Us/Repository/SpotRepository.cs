﻿using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class SpotRepository : Repository<Spot>, ISpotRepository
    {
        public SpotRepository(IConfiguration config, ILogger<Repository<Spot>> logger) : base(config, logger)
        {
        }

        //Find spots by name
        public List<Spot> GetByName(string name)
        {
            var query = $"select name,address,telephone,workinghours " +
                        $"from spots.spot where name like @name";
            var parameters = new DynamicParameters();
            parameters.Add("@name", "%" + name + "%");

            return ExecuteQuery(query, parameters);
        }

        //Find Spots per Customer
        public List<Spot> GetByCustomer(int custid)
        {
            var query = $"select name,address,telephone,workinghours " +
                        $"from spots.spot where id in (select spotid from customers.custspots " +
                        $"where custid=@custid)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            return ExecuteQuery(query, parameters);
        }

        public void InsertSpotToCustomer(int spotid, int custid)
        {
            var query = $"insert into customers.custspots values" +
                        $"(@custid,@spotid)";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void RemoveSpotToCustomer(int spotid, int custid)
        {
            var query = $"delete from customers.custspots where " +
                        $"custid=@custid and spotid=@spotid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void InactivateSpot(int id)
        {
            var query = $"update spots.spot " +
            $"set status=0 where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            ExecuteQuery(query, parameters);

            return;
        }

        public void ActivateSpot(int id)
        {
            var query = $"update spots.spot " +
            $"set status=1 where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
