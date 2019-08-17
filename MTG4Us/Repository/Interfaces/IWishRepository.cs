using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IWishRepository : IRepository<Wish>
    {
        void InsertWish(Wish wish);

        List<Wish> GetWishesPerCustomer(int custid);

        List<Wish> GetWishesPerSpot(int spotid);

        List<Wish> GetWishesPerCustomerSpot(int custid, int spotid);

        void AttendWish(WishTarget target);

        void GrantWish(Exchange exchange);
    }
}
