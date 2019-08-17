using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class ScoreBusiness : IScoreBusiness
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreBusiness(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public void DecreaseBorrowRep(int custid)
        {
            _scoreRepository.DecreaseBorrowRep(custid);
            return;
        }

        public void DecreaseOwnerRep(int custid)
        {
            _scoreRepository.DecreaseOwnerRep(custid);
            return;
        }

        public void IncreaseBorrowRep(int custid)
        {
            _scoreRepository.IncreaseBorrowRep(custid);
            return;
        }

        public void IncreaseOwnerRep(int custid)
        {
            _scoreRepository.IncreaseOwnerRep(custid);
            return;
        }

        public Score Insert(Score score)
        {
            return _scoreRepository.Insert(score);
        }

        public List<Score> GetByCustId(int custid)
        {
            return _scoreRepository.GetByCustId(custid);
        }
    }
}
