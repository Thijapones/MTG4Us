using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class WishServices : IWishServices
    {
        private readonly IWishBusiness _wishBusiness;
        public WishServices(IWishBusiness wishBusiness)
        {
            _wishBusiness = wishBusiness;
        }

        public void AttendWish(int wishid, WishTarget target)
        {
            _wishBusiness.AttendWish(wishid, target);
            return;
        }

        public List<Wish> GetWishesPerCustomer(int custid)
        {
            return _wishBusiness.GetWishesPerCustomer(custid);
        }

        public List<Wish> GetWishesPerCustomerSpot(int custid, int spotid)
        {
            return _wishBusiness.GetWishesPerCustomerSpot(custid, spotid);
        }

        public List<Wish> GetWishesPerSpot(int spotid)
        {
            return _wishBusiness.GetWishesPerSpot(spotid);
        }

        public void GrantWish(Exchange exchange)
        {
            _wishBusiness.GrantWish(exchange);
            return;
        }

        public void InsertWish(Wish wish)
        {
            _wishBusiness.InsertWish(wish);
            return;
        }
    }
}
