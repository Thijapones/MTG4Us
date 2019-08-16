using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class BagRepository : Repository<Bag>, IBagRepository
    {
        public BagRepository(IConfiguration config, ILogger<Repository<Bag>> logger) : base(config, logger)
        {
        }

        public List<Bag> GetbyCustomer(int custid)
        {
            var query = $"select * " +
                        $"from customers.vwbag where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            return ExecuteQuery(query, parameters);
        }

        public List<Bag> GetbyOwner(int ownerid)
        {
            var query = $"select * " +
                        $"from customers.vwbag where ownerid=@ownerid and status=0";
            var parameters = new DynamicParameters();
            parameters.Add("@ownerid", ownerid);
            return ExecuteQuery(query, parameters);
        }

        public List<Bag> GetbyWish(int wishid)
        {
            var query = $"select * " +
                        $"from customers.vwbag where ownerid=@ownerid and status=0";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", wishid);
            return ExecuteQuery(query, parameters);
        }

        public void InsertNewBag(Wish wish)
        {
            var query =
                $"insert into customers.bag" +
                $" values(@custid, @ownerid, @itemid, @quantity,@wishid,@returndate,0)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", wish.custid);
            parameters.Add("@ownerid", wish.ownerid);
            parameters.Add("@itemid", wish.itemid);
            parameters.Add("@quantity", wish.quantity);
            parameters.Add("@wishid", wish.id);
            parameters.Add("@returndate", wish.returndate);

            ExecuteQuery(query, parameters);

            return;
        }

        public void ReturnBagItem(int bagid, int status)
        {
            var query =
                $"update customers.bag" +
                $" set status=@status,returndate=getdate() where bagid=@bagid";
            var parameters = new DynamicParameters();
            parameters.Add("@bagid", bagid);
            parameters.Add("@status", status);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
