using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class WishTargetServices : IWishTargetServices
    {
        private readonly IWishTargetBusiness _wishtargetBusiness;
        public WishTargetServices(IWishTargetBusiness wishtargetBusiness)
        {
            _wishtargetBusiness = wishtargetBusiness;
        }

        public List<WishTarget> GetbyWishId(int wishid)
        {
            return _wishtargetBusiness.GetbyWishId(wishid);
        }
    }
}
