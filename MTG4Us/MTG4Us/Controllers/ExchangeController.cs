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
    public class ExchangeController : ControllerBase
    {
        private readonly IExchangeServices _exchangeServices;
        private readonly ILogger<ExchangeController> _logger;
        private readonly IMapper _mapper;
        public ExchangeController(IExchangeServices customerServices, ILogger<ExchangeController> logger, IMapper mapper)
        {
            _exchangeServices = customerServices;
            _logger = logger;
            _mapper = mapper;
        }


    }
}