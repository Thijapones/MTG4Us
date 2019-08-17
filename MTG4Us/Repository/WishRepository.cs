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

        public void InsertWish(Wish wish)
        {
            var query = $"insert into transactions.wish values" +
            $"(@custid,null,null,@itemid,@quantity,null,@returndate,getdate() +7,1)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", wish.custid);
            parameters.Add("@itemid", wish.itemid);
            parameters.Add("@quantity", wish.quantity);
            parameters.Add("@returndate", wish.returndate);

            ExecuteQuery(query, parameters);

            return;
        }

        public List<Wish> GetWishesPerCustomer(int custid)
        {
            var query = $"select * " +
                        $"from transactions.vwwish where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            return ExecuteQuery(query, parameters);
        }

        public List<Wish> GetWishesPerSpot(int spotid)
        {
            var query = $"select * " +
                        $"from transactions.vwwish where spotid=@spotid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);

            return ExecuteQuery(query, parameters);
        }

        public List<Wish> GetWishesPerCustomerSpot(int custid, int spotid)
        {
            var query = $"select * " +
                        $"from transactions.vwwish where custid=@custid and spotid=@spotid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            parameters.Add("@spotid", spotid);

            return ExecuteQuery(query, parameters);
        }

        public void AttendWish(WishTarget target)
        {
            var query =
                $"update transactions.wish " +
                $"set ownerid=@ownerid, spotid=@spotid, quantity=@quantity," +
                $" shelfid=@shelfid, status=2 where id=@wishid";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", target.wishid);
            parameters.Add("@ownerid", target.ownerid);
            parameters.Add("@spotid", target.spotid);
            parameters.Add("@quantity", target.quantity);
            parameters.Add("@shelfid", target.shelfid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void GrantWish(Exchange exchange)
        {
            var query =
                $"update transactions.wish " +
                $"set boxid=@boxid, status=3 where id=@wishid";
            var parameters = new DynamicParameters();
            parameters.Add("@wishid", exchange.wishid);
            parameters.Add("@boxid", exchange.boxid);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
