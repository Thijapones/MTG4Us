using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class ScoreServices : IScoreServices
    {
        private readonly IScoreBusiness _scoreBusiness;
        public ScoreServices(IScoreBusiness scoreBusiness)
        {
            _scoreBusiness = scoreBusiness;
        }

        public void DecreaseBorrowRep(int custid)
        {
            _scoreBusiness.DecreaseBorrowRep(custid);
            return;
        }

        public void DecreaseOwnerRep(int custid)
        {
            _scoreBusiness.DecreaseOwnerRep(custid);
            return;
        }

        public void IncreaseBorrowRep(int custid)
        {
            _scoreBusiness.IncreaseBorrowRep(custid);
            return;
        }

        public void IncreaseOwnerRep(int custid)
        {
            _scoreBusiness.IncreaseOwnerRep(custid);
            return;
        }

        public Score Insert(Score score)
        {
            return _scoreBusiness.Insert(score);
        }

        public List<Score> GetByCustId(int custid)
        {
            return _scoreBusiness.GetByCustId(custid);
        }

    }
}
