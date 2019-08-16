using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IScoreBusiness
    {
        Score Insert(Score score);

        void IncreaseOwnerRep(int custid);

        void DecreaseOwnerRep(int custid);

        void IncreaseBorrowRep(int custid);

        void DecreaseBorrowRep(int custid);
    }
}
