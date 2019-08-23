using System;
using System.Collections.Generic;
using System.Web.Http.Cors;
using Application.ViewModels;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace Application.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [Route("api/[controller]")]
    [ApiController]
    public class BagController : ControllerBase
    {
        private readonly IBagServices _bagServices;
        private readonly ILogger<BagController> _logger;
        private readonly IMapper _mapper;
        public BagController(IBagServices customerServices, ILogger<BagController> logger, IMapper mapper)
        {
            _bagServices = customerServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<BagViewModel> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get Bag request");
                var result = _bagServices.GetById(id);
                return Ok(_mapper.Map<BagViewModel>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Customer/{custid}")]
        public ActionResult<List<BagViewModel>> GetbyCustomer(int custid)
        {
            try
            {
                _logger.LogInformation("Received get list Bag request");
                var result = _bagServices.GetbyCustomer(custid);
                return Ok(_mapper.Map<List<BagViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Owner/{ownerid}")]
        public ActionResult<List<BagViewModel>> GetbyOwner(int ownerid)
        {
            try
            {
                _logger.LogInformation("Received get list Bag request");
                var result = _bagServices.GetbyOwner(ownerid);
                return Ok(_mapper.Map<List<BagViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Wish/{wishid}")]
        public ActionResult<List<BagViewModel>> GetbyWish(int wishid)
        {
            try
            {
                _logger.LogInformation("Received get list Bag request");
                var result = _bagServices.GetbyWish(wishid);
                return Ok(_mapper.Map<List<BagViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> InsertNewBag([FromBody] WishViewModel wish)
        {
            try
            {
                _logger.LogInformation("Received post Bag request");
                _bagServices.InsertNewBag(_mapper.Map<Wish>(wish));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("{bagid}")]
        public ActionResult<string> ReturnBagItem([FromRoute] int bagid, int status)
        {
            try
            {
                _logger.LogInformation("Received delete Box to Customer request");
                _bagServices.ReturnBagItem(bagid,status);
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}