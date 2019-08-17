using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels;
using AutoMapper;
using Domain;
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

        [HttpGet("{id}")]
        public ActionResult<WishViewModel> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get Wish request");
                var result = _wishServices.GetById(id);
                return Ok(_mapper.Map<WishViewModel>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Customer/{custid}")]
        public ActionResult<List<WishViewModel>> GetWishesPerCustomer(int custid)
        {
            try
            {
                _logger.LogInformation("Received get list Box request");
                var result = _wishServices.GetWishesPerCustomer(custid);
                return Ok(_mapper.Map<List<WishViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Spot/{spotid}")]
        public ActionResult<List<WishViewModel>> GetWishesPerSpot(int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Wish request");
                var result = _wishServices.GetWishesPerSpot(spotid);
                return Ok(_mapper.Map<List<WishViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("CustSpot/{spotid}")]
        public ActionResult<List<WishViewModel>> GetWishesPerCustomerSpot([FromHeader] int custid, int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Wish request");
                var result = _wishServices.GetWishesPerCustomerSpot(custid, spotid);
                return Ok(_mapper.Map<List<WishViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> InsertWish(WishViewModel wish)
        {
            try
            {
                _logger.LogInformation("Received post Wish request");
                _wishServices.InsertWish(_mapper.Map<Wish>(wish));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Grant/")]
        public ActionResult<string> GrantWish([FromBody] ExchangeViewModel exchange)
        {
            try
            {
                _logger.LogInformation("Received patch Wish Grant request");
                _wishServices.GrantWish(_mapper.Map<Exchange>(exchange));
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Attend/")]
        public ActionResult<string> AttendWish([FromBody] WishTargetViewModel target)
        {
            try
            {
                _logger.LogInformation("Received patch Wish Grant request");
                _wishServices.AttendWish(_mapper.Map<WishTarget>(target));
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}