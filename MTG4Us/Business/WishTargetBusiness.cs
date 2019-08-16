using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class WishTargetBusiness : IWishTargetBusiness
    {
        private readonly IWishTargetRepository _wishtargetRepository;

        public WishTargetBusiness(IWishTargetRepository wishtargetRepository)
        {
            _wishtargetRepository = wishtargetRepository;
        }

        public List<WishTarget> GetbyWishId(int wishid)
        {
            return _wishtargetRepository.GetbyWishId(wishid);
        }
    }
}
