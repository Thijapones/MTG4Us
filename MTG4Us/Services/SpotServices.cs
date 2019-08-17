using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class SpotServices : ISpotServices
    {
        private readonly ISpotBusiness _spotBusiness;
        public SpotServices(ISpotBusiness spotBusiness)
        {
            _spotBusiness = spotBusiness;
        }

        public void ActivateSpot(int id)
        {
            _spotBusiness.ActivateSpot(id);
            return;
        }

        public List<Spot> GetAll()
        {
            return _spotBusiness.GetAll();
        }

        public List<Spot> GetByCustomer(int custid)
        {
            return _spotBusiness.GetByCustomer(custid);
        }

        public Spot GetById(int id)
        {
            return _spotBusiness.GetById(id);
        }

        public List<Spot> GetByName(string name)
        {
            return _spotBusiness.GetByName(name);
        }

        public void InactivateSpot(int id)
        {
            _spotBusiness.InactivateSpot(id);
            return;
        }

        public Spot Insert(Spot spot)
        {
            return _spotBusiness.Insert(spot);
        }

        public void InsertSpotToCustomer(int spotid, int custid)
        {
            _spotBusiness.InsertSpotToCustomer(spotid, custid);
            return;
        }

        public void RemoveSpotToCustomer(int spotid, int custid)
        {
            _spotBusiness.RemoveSpotToCustomer(spotid,custid);
            return;
        }

        public Spot Update(Spot spot)
        {
            return _spotBusiness.Update(spot);
        }
    }
}
