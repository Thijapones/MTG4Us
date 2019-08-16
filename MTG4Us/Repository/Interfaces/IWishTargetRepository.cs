using Domain;
using Repository.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IWishTargetRepository : IRepository<WishTarget>
    {
        List<WishTarget> GetbyWishId(int wishid);
    }
}
