using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class MTGCardController : ControllerBase
    {
        private readonly IMTGCardServices _mtgcardServices;
        private readonly ILogger<MTGCardController> _logger;
        private readonly IMapper _mapper;

        public MTGCardController(IMTGCardServices spotServices, ILogger<MTGCardController> logger, IMapper mapper)
        {
            _mtgcardServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<MTGCard>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received GetAll request");
                var clients = _mtgcardServices.GetAll();
                return Ok(_mapper.Map<List<MTGCard>>(clients));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Name/{name}")]
        public ActionResult<List<MTGCard>> GetByName(string name)
        {
            try
            {
                _logger.LogInformation("Received get list MTGCard request");
                var result = _mtgcardServices.GetByName(name);
                return Ok(_mapper.Map<List<MTGCard>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Set/{set}")]
        public ActionResult<List<MTGCard>> GetBySet(string set)
        {
            try
            {
                _logger.LogInformation("Received get list MTGCard request");
                var result = _mtgcardServices.GetBySet(set);
                return Ok(_mapper.Map<List<MTGCard>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("SetCode/{setcode}")]
        public ActionResult<List<MTGCard>> GetBySetCode(string setcode)
        {
            try
            {
                _logger.LogInformation("Received get list MTGCard request");
                var result = _mtgcardServices.GetBySetCode(setcode);
                return Ok(_mapper.Map<List<MTGCard>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("MTGId/{mtgid}")]
        public ActionResult<List<MTGCard>> GetByMTGId(int mtgid)
        {
            try
            {
                _logger.LogInformation("Received get list MTGCard request");
                var result = _mtgcardServices.GetByMTGId(mtgid);
                return Ok(_mapper.Map<List<MTGCard>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}