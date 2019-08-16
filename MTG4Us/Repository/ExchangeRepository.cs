using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class ExchangeRepository : Repository<Exchange>, IExchangeRepository
    {
        public ExchangeRepository(IConfiguration config, ILogger<Repository<Exchange>> logger) : base(config, logger)
        {

        }

        //Get Exchange by Wish Id
        public List<Exchange> GetbyWish(int wishid)
        {
            var query = $"select *" +
                        $"from transactions.exchange where wishid=@wishid";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", wishid);
            return ExecuteQuery(query, parameters);
        }

        //Create an exchange when a spot admin places an item to be retrieved in a box.
        public void NewExchange(int wishid,int boxid, int shelfid)
        {
            var query =
                $"insert into transactions.exchange" +
                $"values(@wishid,@boxid,null,@shelfid,1)";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", wishid);
            parameters.Add("@boxid", boxid);
            parameters.Add("@shelfid", shelfid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void GrantExchange(int exchangeid, int bagid)
        {
            var query =
                $"update transactions.exchange" +
                $"set bagid=@bagid,status=2 where id=@exchangeid";
            var parameters = new DynamicParameters();
            parameters.Add("@exchangeid", exchangeid);
            parameters.Add("@bagid", bagid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void ReturnExchange(int exchangeid, int boxid)
        {
            var query =
                $"update transactions.exchange" +
                $"set boxid=@boxid,status=3 where id=@exchangeid";
            var parameters = new DynamicParameters();
            parameters.Add("@exchangeid", exchangeid);
            parameters.Add("@boxid", boxid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void AccomplishExchange(int exchangeid)
        {
            var query =
                $"update transactions.exchange" +
                $"set status=4 where id=@exchangeid";
            var parameters = new DynamicParameters();
            parameters.Add("@exchangeid", exchangeid);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
