using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class BoxRepository : Repository<Box>, IBoxRepository
    {
        public BoxRepository(IConfiguration config, ILogger<Repository<Box>> logger) : base(config, logger)
        {
        }

        public List<Box> GetbySpot(int spotid)
        {
            var query = $"select * " +
                        $"from spots.vwbox where spotid=@spotid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            return ExecuteQuery(query, parameters);
        }

        public List<Box> GetbySpotCust(int spotid, int custid)
        {
            var query = $"select * " +
                        $"from spots.vwbox where spotid=@spotid and custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@custid", custid);
            return ExecuteQuery(query, parameters);
        }

        public List<Box> GetbySpotOwner(int spotid, int ownerid)
        {
            var query = $"select * " +
                        $"from spots.vwbox where spotid=@spotid and ownerid=@ownerid";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@ownerid", ownerid);
            return ExecuteQuery(query, parameters);
        }

        public List<Box> GetbySpotBoxNumber(int spotid, int boxnumber)
        {
            var query = $"select * " +
                        $"from spots.vwbox where spotid=@spotid and boxnumber=@boxnumber";
            var parameters = new DynamicParameters();
            parameters.Add("@spotid", spotid);
            parameters.Add("@boxnumber", boxnumber);
            return ExecuteQuery(query, parameters);
        }

        public void InsertNewBox(int spotid, int boxnumber)
        {
            var query =
                $"insert into spots.box " +
                $" values(@boxnumber,@spotid,null,null,null,0)";
            var parameters = new DynamicParameters();
            parameters.Add("@boxnumber", boxnumber);
            parameters.Add("@spotid", spotid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void UpdateBox(Wish wish)
        {
            var query =
                $"update spots.box " +
                $"set custid=@custid,ownerid=@ownerid,shelfid=@shelfid where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", wish.custid);
            parameters.Add("@ownerid", wish.ownerid);
            parameters.Add("@shelfid", wish.shelfid);
            parameters.Add("@boxid", wish.boxid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void SetBoxEmpty(int boxid)
        {
            var query =
                $"update spots.box " +
                $"set status=0 where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void SetBoxOccupied(int boxid)
        {
            var query =
                $"update spots.box " +
                $"set status=1 where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void RemoveBox(int boxid)
        {
            var query = "delete from spots.box where id=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);

            ExecuteQuery(query, parameters);

            return;
        }

    }
}
