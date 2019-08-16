using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class WishRepository : Repository<Wish>, IWishRepository
    {
        public WishRepository(IConfiguration config, ILogger<Repository<Wish>> logger) : base(config, logger)
        {
        }
        //Wishes cannot be removed. They must be set to Expired.

        //Gets all wishes per customer.
        public List<Wish> GetWishesPerCustomer(int custid)
        {
            var query = $"select *" +
                        $"from transactions.vwwish where custid=@custid)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            return ExecuteQuery(query, parameters);
        }

        public List<Wish> GetWishesPerCustomerSpot(int custid, int spotid)
        {
            var query = $"select *" +
                        $"from transactions.vwwish where custid=@custid and spotid=@spotid)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            parameters.Add("@spotid", spotid);

            return ExecuteQuery(query, parameters);
        }

        public void AttendWish(int wishid, WishTarget target)
        {
            var query =
                $"update transactions.wish" +
                $"set ownerid=@ownerid, spotid=@spotid, quantity=@quantity, status=2 where id=@wishid";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", wishid);
            parameters.Add("@ownerid", target.ownerid);
            parameters.Add("@spotid", target.spotid);
            parameters.Add("@quantity", target.quantity);

            ExecuteQuery(query, parameters);

            return;
        }

        public void GrantWish(int wishid, Exchange exchange)
        {
            var query =
                $"update transactions.wish" +
                $"set boxid=@boxid, status=3 where id=@wishid";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", wishid);
            parameters.Add("@boxid", exchange.boxid);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
