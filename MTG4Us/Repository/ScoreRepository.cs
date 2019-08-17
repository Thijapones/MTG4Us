using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(IConfiguration config, ILogger<Repository<Score>> logger) : base(config, logger)
        {

        }

        //A Score will only be inserted once, during customer creation.
        public override Score Insert(Score score)
        {
            var query =
                $"insert into customers.score " +
                $" values(@custid,0,0,0,0)";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", score.custid);

            ExecuteQuery(query, parameters);
            return score;
        }

        public List<Score> GetByCustId(int custid)
        {
            var query =
                $"select * from customers.vwscore " +
                $"where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            return ExecuteQuery(query, parameters);
        }

        public void IncreaseOwnerRep(int custid)
        {
            var query =
                $"update customers.score " +
                $"set ownerpositive=ownerpositive+1 where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void DecreaseOwnerRep(int custid)
        {
            var query =
                $"update customers.score " +
                $"set ownernegative=ownernegative+1 where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void IncreaseBorrowRep(int custid)
        {
            var query =
                $"update customers.score " +
                $"set borrowerpositive=borrowerpositive+1 where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }

        public void DecreaseBorrowRep(int custid)
        {
            var query =
                $"update customers.score " +
                $"set borrowernegative=borrowernegative+1 where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
