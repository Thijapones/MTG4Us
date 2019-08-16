using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IBagRepository : IRepository<Bag>
    {
        List<Bag> GetbyCustomer(int custid);

        List<Bag> GetbyOwner(int ownerid);

        List<Bag> GetbyWish(int wishid);

        void InsertNewBag(Wish wish);

        void ReturnBagItem(int bagid, int status);
    }
}
