using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SpotController : ControllerBase
    {
        private readonly ISpotServices _spotServices;
        private readonly ILogger<SpotController> _logger;
        private readonly IMapper _mapper;

        public SpotController(ISpotServices spotServices, ILogger<SpotController> logger, IMapper mapper)
        {
            _spotServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<Spot>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received GetAll request");
                var clients = _spotServices.GetAll();
                return Ok(_mapper.Map<List<Spot>>(clients));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Spot> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get list Spot request");
                var result = _spotServices.GetById(id);
                return Ok(_mapper.Map<Spot>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Name/{name}")]
        public ActionResult<List<Spot>> GetByName(string name)
        {
            try
            {
                _logger.LogInformation("Received get list Spot request");
                var result = _spotServices.GetByName(name);
                return Ok(_mapper.Map<List<Spot>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Customer/{id}")]
        public ActionResult<List<Spot>> GetByCustomer(int id)
        {
            try
            {
                _logger.LogInformation("Received get list Spot request");
                var result = _spotServices.GetByCustomer(id);
                return Ok(_mapper.Map<List<Spot>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> InsertSpot([FromBody] Spot spot)
        {
            try
            {
                _logger.LogInformation("Received post Spot request");
                _spotServices.Insert(_mapper.Map<Spot>(spot));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost("Customer/{custid}")]
        public ActionResult<string> InsertSpotToCustomer([FromHeader] int spotid, int custid)
        {
            try
            {
                _logger.LogInformation("Received post Spot to Customer request");
                _spotServices.InsertSpotToCustomer(spotid,custid);
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Spot> Update(Spot customer)
        {
            try
            {
                _logger.LogInformation("Received put Spot request");
                _spotServices.Update(_mapper.Map<Spot>(customer));
                return Ok(_mapper.Map<Spot>(customer));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Activate/{id}")]
        public ActionResult<string> ActivateSpot(int id)
        {
            try
            {
                _logger.LogInformation("Received activate Spot request");
                _spotServices.ActivateSpot(id);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Inactivate/{id}")]
        public ActionResult<string> InactivateSpot(int id)
        {
            try
            {
                _logger.LogInformation("Received inactivate Spot request");
                _spotServices.InactivateSpot(id);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("Customer/{custid}")]
        public ActionResult<string> RemoveSpotToCustomer([FromHeader] int spotid, int custid)
        {
            try
            {
                _logger.LogInformation("Received delete Spot to Customer request");
                _spotServices.RemoveSpotToCustomer(spotid, custid);
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