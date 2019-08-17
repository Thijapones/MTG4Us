using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IScoreRepository : IRepository<Score>
    {
        List<Score> GetByCustId(int custid);

        void IncreaseOwnerRep(int custid);

        void DecreaseOwnerRep(int custid);

        void IncreaseBorrowRep(int custid);

        void DecreaseBorrowRep(int custid);
    }
}
