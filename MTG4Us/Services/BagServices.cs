using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class BagServices : IBagServices
    {
        private readonly IBagBusiness _bagBusiness;
        public BagServices(IBagBusiness bagBusiness)
        {
            _bagBusiness = bagBusiness;
        }

        public List<Bag> GetbyCustomer(int custid)
        {
            return _bagBusiness.GetbyCustomer(custid);
        }

        public List<Bag> GetbyOwner(int ownerid)
        {
            return _bagBusiness.GetbyOwner(ownerid);
        }

        public List<Bag> GetbyWish(int wishid)
        {
            return _bagBusiness.GetbyWish(wishid);
        }

        public void InsertNewBag(Wish wish)
        {
            _bagBusiness.InsertNewBag(wish);
            return;
        }

        public void ReturnBagItem(int bagid, int status)
        {
            _bagBusiness.ReturnBagItem(bagid, status);
            return;
        }

        public Bag GetById(int id)
        {
            return _bagBusiness.GetById(id);
        }
    }
}
