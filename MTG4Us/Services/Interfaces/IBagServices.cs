using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBagServices
    {
        void InsertNewBag(Wish wish);

        List<Bag> GetbyCustomer(int custid);

        List<Bag> GetbyOwner(int ownerid);

        List<Bag> GetbyWish(int wishid);

        void ReturnBagItem(int bagid, int status);
    }
}
