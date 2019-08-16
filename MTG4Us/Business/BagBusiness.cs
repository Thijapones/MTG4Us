using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class BagBusiness : IBagBusiness
    {
        private readonly IBagRepository _bagRepository;

        public BagBusiness(IBagRepository bagRepository)
        {
            _bagRepository = bagRepository;
        }
        public List<Bag> GetbyCustomer(int custid)
        {
            return _bagRepository.GetbyCustomer(custid);
        }

        public List<Bag> GetbyOwner(int ownerid)
        {
            return _bagRepository.GetbyOwner(ownerid);
        }

        public List<Bag> GetbyWish(int wishid)
        {
            return _bagRepository.GetbyWish(wishid);
        }

        public void InsertNewBag(Wish wish)
        {
            _bagRepository.InsertNewBag(wish);
            return;
        }

        public void ReturnBagItem(int bagid, int status)
        {
            _bagRepository.ReturnBagItem(bagid, status);
            return;
        }
    }
}
