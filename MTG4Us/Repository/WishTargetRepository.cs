using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class WishTargetRepository : Repository<WishTarget>, IWishTargetRepository
    {
        public WishTargetRepository(IConfiguration config, ILogger<Repository<WishTarget>> logger) : base(config, logger)
        {
        }
    }
}
