using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBagBusiness
    {
        /// <summary>
        /// A bag displays the items currently in possession of the customer.
        /// A bag can never be removed. A query over bags will only take account of items not returned.
        /// </summary>

        void InsertNewBag(Wish wish);

        List<Bag> GetbyCustomer(int custid);

        List<Bag> GetbyOwner(int ownerid);

        List<Bag> GetbyWish(int wishid);

        void ReturnBagItem(int bagid, int status);
    }
}
