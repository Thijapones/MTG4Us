using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IWishRepository : IRepository<Wish>
    {
        List<Wish> ExecuteQuery(int userid, int itemid);
    }
}
