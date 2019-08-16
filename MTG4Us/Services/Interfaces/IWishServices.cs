using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IWishServices
    {
        void InsertWish(Wish wish);

        List<Wish> GetWishesPerCustomer(int custid);

        List<Wish> GetWishesPerSpot(int spotid);

        List<Wish> GetWishesPerCustomerSpot(int custid, int spotid);

        void AttendWish(int wishid, WishTarget target);

        void GrantWish(Exchange exchange);
    }
}
