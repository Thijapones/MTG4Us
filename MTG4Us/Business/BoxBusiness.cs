using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class BoxBusiness : IBoxBusiness
    {
        private readonly IBoxRepository _boxRepository;

        public BoxBusiness(IBoxRepository boxRepository)
        {
            _boxRepository = boxRepository;
        }

        public Box GetById(int boxid)
        {
            return _boxRepository.GetById(boxid);
        }

        public List<Box> GetbySpot(int spotid)
        {
            return _boxRepository.GetbySpot(spotid);
        }

        public List<Box> GetbySpotBoxNumber(int spotid, int boxnumber)
        {
            return _boxRepository.GetbySpotBoxNumber(spotid,boxnumber);
        }

        public List<Box> GetbySpotCust(int spotid, int custid)
        {
            return _boxRepository.GetbySpotCust(spotid,custid);
        }

        public List<Box> GetbySpotOwner(int spotid, int ownerid)
        {
            return _boxRepository.GetbySpotOwner(spotid, ownerid);
        }

        public void InsertNewBox(int spotid, int boxnumber)
        {
            _boxRepository.InsertNewBox(spotid, boxnumber);
            return;
        }

        public void RemoveBox(int boxid)
        {
            _boxRepository.RemoveBox(boxid);
            return;
        }

        public void SetBoxEmpty(int boxid)
        {
            _boxRepository.SetBoxEmpty(boxid);
            return;
        }

        public void SetBoxOccupied(int boxid)
        {
            _boxRepository.SetBoxOccupied(boxid);
            return;
        }

        public void UpdateBox(Wish wish)
        {
            _boxRepository.UpdateBox(wish);
            return;
        }
    }
}
