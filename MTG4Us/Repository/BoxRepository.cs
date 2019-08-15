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
    public class BoxRepository : Repository<Box>, IBoxRepository
    {
        public BoxRepository(IConfiguration config, ILogger<Repository<Box>> logger) : base(config, logger)
        {
        }

        public List<Box> GetbySpot(int spotid)
        {
            var query = $"select *" +
                        $"from spots.vwbox where spotid=@spotid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            return ExecuteQuery(query, parameters);
        }

        public List<Box> GetbySpotCust(int spotid, int custid)
        {
            var query = $"select *" +
                        $"from spots.vwbox where spotid=@spotid and custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@custid", custid);
            return ExecuteQuery(query, parameters);
        }

        public void InsertNewBox(Spot spot, int boxnumber)
        {
            var query =
                $"insert into spots.box" +
                $" values(@boxnumber,@spotid,null,null,0)";
            var parameters = new DynamicParameters();
            parameters.Add("@boxnumber", boxnumber);
            parameters.Add("@spotid", spot.id);

            ExecuteQuery(query, parameters);

            return;
        }

        public void UpdateBox(Box box, Wish wish)
        {
            var query =
                $"update spots.box" +
                $"set custid=@custid,ownerid=@ownerid where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", wish.custid);
            parameters.Add("@owner", wish.ownerid);
            parameters.Add("@box", box.id);

            ExecuteQuery(query, parameters);

            return;
        }

        public override bool Remove(Box box)
        {
            var query = "delete from spots.box where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", box.id);

            ExecuteQuery(query, parameters);

            return true;
        }

    }
}
