using System;
using System.Collections.Generic;
using Application.ViewModels;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        private readonly IShelfServices _shelfServices;
        private readonly ILogger<ShelfController> _logger;
        private readonly IMapper _mapper;

        public ShelfController(IShelfServices spotServices, ILogger<ShelfController> logger, IMapper mapper)
        {
            _shelfServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<ShelfViewModel> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get list Shelf request");
                var result = _shelfServices.GetById(id);
                return Ok(_mapper.Map<ShelfViewModel>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("CustItem/{itemid}")]
        public ActionResult<List<ShelfViewModel>> GetbyCustItem([FromHeader] int custid, int itemid)
        {
            try
            {
                _logger.LogInformation("Received get list Shelf request");
                var result = _shelfServices.GetbyCustItem(custid, itemid);
                return Ok(_mapper.Map<List<ShelfViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Customer/{custid}")]
        public ActionResult<List<ShelfViewModel>> GetbyCustomer(int custid)
        {
            try
            {
                _logger.LogInformation("Received get list Shelf request");
                var result = _shelfServices.GetbyCustomer(custid);
                return Ok(_mapper.Map<List<ShelfViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> InsertShelf([FromBody] ShelfViewModel customer)
        {
            try
            {
                _logger.LogInformation("Received post Shelf request");
                _shelfServices.InsertShelf(_mapper.Map<Shelf>(customer));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Quantity/{shelfid}")]
        public ActionResult<string> UpdateQty([FromHeader] int quantity, int shelfid)
        {
            try
            {
                _logger.LogInformation("Received patch Shelf quantity request");
                _shelfServices.UpdateQty(shelfid, quantity);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("AvailableQuantity/{shelfid}")]
        public ActionResult<string> UpdateAvailQty([FromHeader] int availableqty, int shelfid)
        {
            try
            {
                _logger.LogInformation("Received patch Shelf available quantity request");
                _shelfServices.UpdateAvailQty(shelfid, availableqty);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("MarketPrice/{shelfid}")]
        public ActionResult<string> UpdateMarketPrice([FromHeader] double price, int shelfid)
        {
            try
            {
                _logger.LogInformation("Received patch Shelf marketprice request");
                _shelfServices.UpdateMarketPrice(shelfid, price);
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