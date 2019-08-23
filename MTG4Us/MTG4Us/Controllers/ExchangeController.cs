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

        [HttpGet("Wish/{wishid}")]
        public ActionResult<List<ExchangeViewModel>> GetbyWish(int wishid)
        {
            try
            {
                _logger.LogInformation("Received get list Wish request");
                var result = _exchangeServices.GetbyWish(wishid);
                return Ok(_mapper.Map<List<ExchangeViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost("New/{boxid}")]
        public ActionResult<string> NewExchange([FromRoute] int boxid, [FromBody] WishViewModel wish)
        {
            try
            {
                _logger.LogInformation("Received post Exchange request");
                _exchangeServices.NewExchange(_mapper.Map<Wish>(wish),boxid);
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Grant/{exchangeid}/{bagid}")]
        public ActionResult<string> UpdateBox([FromRoute] int exchangeid, int bagid)
        {
            try
            {
                _logger.LogInformation("Received patch Exchange request");
                _exchangeServices.GrantExchange(exchangeid,bagid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Return/{exchangeid}")]
        public ActionResult<string> ReturnExchange(int boxid, [FromRoute] int exchangeid)
        {
            try
            {
                _logger.LogInformation("Received patch Exchange request");
                _exchangeServices.ReturnExchange(exchangeid, boxid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Complete/{exchangeid}")]
        public ActionResult<string> AccomplishExchange([FromRoute] int exchangeid)
        {
            try
            {
                _logger.LogInformation("Received patch Exchange request");
                _exchangeServices.AccomplishExchange(exchangeid);
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