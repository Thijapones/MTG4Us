using Domain;

namespace Services.Interfaces
{
    public interface IScoreServices
    {
        Score Insert(Score score);

        void IncreaseOwnerRep(int custid);

        void DecreaseOwnerRep(int custid);

        void IncreaseBorrowRep(int custid);

        void DecreaseBorrowRep(int custid);
    }
}
