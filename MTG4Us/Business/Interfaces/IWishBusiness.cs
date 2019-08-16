using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IWishBusiness
    {
        /// <summary>
        ///A Wish should never be removed. Its status should be set to Cancelled instead.
        /// </summary>
        /// <returns></returns>

        void InsertWish(Wish wish);

        List<Wish> GetWishesPerCustomer(int custid);

        List<Wish> GetWishesPerSpot(int spotid);

        List<Wish> GetWishesPerCustomerSpot(int custid, int spotid);

        void AttendWish(int wishid, WishTarget target);

        void GrantWish(Exchange exchange);
    }
}
