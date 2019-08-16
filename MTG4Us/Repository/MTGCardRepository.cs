using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MTGCardRepository : Repository<MTGCard>, IMTGCardRepository
    {
        public MTGCardRepository(IConfiguration config, ILogger<Repository<MTGCard>> logger) : base(config, logger)
        {

        }


    }
}
