using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class WishBusiness : IWishBusiness
    {
        private readonly IWishRepository _wishRepository;

        public WishBusiness(IWishRepository wishRepository)
        {
            _wishRepository = wishRepository;
        }

        public void AttendWish(int wishid, WishTarget target)
        {
            _wishRepository.AttendWish(wishid, target);
            return;
        }

        public List<Wish> GetWishesPerCustomer(int custid)
        {
            return _wishRepository.GetWishesPerCustomer(custid);
        }

        public List<Wish> GetWishesPerCustomerSpot(int custid, int spotid)
        {
            return _wishRepository.GetWishesPerCustomerSpot(custid, spotid);
        }

        public List<Wish> GetWishesPerSpot(int spotid)
        {
            return _wishRepository.GetWishesPerSpot(spotid);
        }

        public void GrantWish(Exchange exchange)
        {
            _wishRepository.GrantWish(exchange);
            return;
        }

        public void InsertWish(Wish wish)
        {
            _wishRepository.InsertWish(wish);
            return;
        }
    }
}
