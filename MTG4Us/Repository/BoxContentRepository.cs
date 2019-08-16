using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class BoxContentRepository : Repository<BoxContent>, IBoxContentRepository
    {
        public BoxContentRepository(IConfiguration config, ILogger<Repository<BoxContent>> logger) : base(config, logger)
        {
        }

        public List<BoxContent> GetbyBox(int boxid)
        {
            var query = $"select *" +
                        $"from spots.boxcontent where boxid=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);
            return ExecuteQuery(query, parameters);
        }

        public void InsertNewContent(Wish wish, int boxid)
        {
            var query =
                $"insert into spots.boxcontent" +
                $" values(@boxid,@itemid,@quantity)";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);
            parameters.Add("@itemid", wish.itemid);
            parameters.Add("@quantity", wish.quantity);

            ExecuteQuery(query, parameters);

            return;
        }

        public void EmptyBox(int boxid)
        {
            var query = "delete from spots.boxcontent where boxid=@boxid";
            var parameters = new DynamicParameters();
            parameters.Add("@boxid", boxid);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
