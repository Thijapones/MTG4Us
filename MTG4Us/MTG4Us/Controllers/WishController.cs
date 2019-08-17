using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishController : ControllerBase
    {
        private readonly IWishServices _wishServices;
        private readonly ILogger<WishController> _logger;
        private readonly IMapper _mapper;

        public WishController(IWishServices spotServices, ILogger<WishController> logger, IMapper mapper)
        {
            _wishServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }


    }
}