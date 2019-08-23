using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class BoxServices : IBoxServices
    {
        private readonly IBoxBusiness _boxBusiness;
        public BoxServices(IBoxBusiness boxBusiness)
        {
            _boxBusiness = boxBusiness;
        }

        public Box GetById(int boxid)
        {
            return _boxBusiness.GetById(boxid);
        }

        public List<Box> GetbySpot(int spotid)
        {
            return _boxBusiness.GetbySpot(spotid);
        }

        public List<Box> GetbySpotBoxNumber(int spotid, int boxnumber)
        {
            return _boxBusiness.GetbySpotBoxNumber(spotid, boxnumber);
        }

        public List<Box> GetbySpotCust(int spotid, int custid)
        {
            return _boxBusiness.GetbySpotCust(spotid, custid);
        }

        public List<Box> GetbySpotOwner(int spotid, int ownerid)
        {
            return _boxBusiness.GetbySpotOwner(spotid, ownerid);
        }

        public void InsertNewBox(int spotid, string boxnumber)
        {
            _boxBusiness.InsertNewBox(spotid, boxnumber);
            return;
        }

        public void RemoveBox(int boxid)
        {
            _boxBusiness.RemoveBox(boxid);
            return;
        }

        public void SetBoxEmpty(int boxid)
        {
            _boxBusiness.SetBoxEmpty(boxid);
            return;
        }

        public void SetBoxOccupied(int boxid)
        {
            _boxBusiness.SetBoxOccupied(boxid);
            return;
        }

        public void UpdateBox(Wish wish)
        {
            _boxBusiness.UpdateBox(wish);
            return;
        }
    }
}
