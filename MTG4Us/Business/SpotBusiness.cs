using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class SpotBusiness : ISpotBusiness
    {
        private readonly ISpotRepository _spotRepository;

        public SpotBusiness(ISpotRepository spotRepository)
        {
            _spotRepository = spotRepository;
        }

        public void ActivateSpot(int id)
        {
            _spotRepository.ActivateSpot(id);
            return;
        }

        public List<Spot> GetAll()
        {
            return _spotRepository.GetAll();
        }

        public List<Spot> GetByCustomer(int custid)
        {
            return _spotRepository.GetByCustomer(custid);
        }

        public Spot GetById(int id)
        {
            return _spotRepository.GetById(id);
        }

        public List<Spot> GetByName(string name)
        {
            return _spotRepository.GetByName(name);
        }

        public void InactivateSpot(int id)
        {
            _spotRepository.InactivateSpot(id);
            return;
        }

        public Spot Insert(Spot spot)
        {
            return _spotRepository.Insert(spot);
        }

        public void InsertSpotToCustomer(int spotid, int custid)
        {
            _spotRepository.InsertSpotToCustomer(spotid, custid);
            return;
        }

        public void RemoveSpotToCustomer(int spotid, int custid)
        {
            _spotRepository.RemoveSpotToCustomer(spotid,custid);
            return;
        }

        public Spot Update(Spot spot)
        {
            return _spotRepository.Update(spot);
        }
    }
}
