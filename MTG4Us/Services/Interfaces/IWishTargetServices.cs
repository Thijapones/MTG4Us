using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IWishTargetServices
    {
        List<WishTarget> GetbyWishId(int wishid);
    }
}
