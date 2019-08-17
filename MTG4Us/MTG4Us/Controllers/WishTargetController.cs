using System;
using System.Collections.Generic;
using Application.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishTargetController : ControllerBase
    {
        private readonly IWishTargetServices _wishtargetServices;
        private readonly ILogger<WishTargetController> _logger;
        private readonly IMapper _mapper;

        public WishTargetController(IWishTargetServices spotServices, ILogger<WishTargetController> logger, IMapper mapper)
        {
            _wishtargetServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{wishid}")]
        public ActionResult<List<WishTargetViewModel>> GetbyWishId(int wishid)
        {
            try
            {
                _logger.LogInformation("Received get Wish request");
                var result = _wishtargetServices.GetbyWishId(wishid);
                return Ok(_mapper.Map<List<WishTargetViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}