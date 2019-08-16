using Domain;
using Repository.Interfaces.Base;

namespace Repository.Interfaces
{
    public interface IScoreRepository : IRepository<Score>
    {
        void IncreaseOwnerRep(int custid);

        void DecreaseOwnerRep(int custid);

        void IncreaseBorrowRep(int custid);

        void DecreaseBorrowRep(int custid);
    }
}
