using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IWishTargetBusiness
    {
        /// <summary>
        ///A WishTarget is a list of possible targets for a given wish.
        ///It must not persist on the database.
        ///Once a target is set, the wish is updated and the WishTarget can be purged.
        /// </summary>
        /// <returns></returns>
        List<WishTarget> GetbyWishId(int wishid);
    }
}
