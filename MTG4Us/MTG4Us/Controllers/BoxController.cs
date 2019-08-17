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
    public class BoxController : ControllerBase
    {
        private readonly IBoxServices _boxServices;
        private readonly ILogger<BoxController> _logger;
        private readonly IMapper _mapper;
        public BoxController(IBoxServices customerServices, ILogger<BoxController> logger, IMapper mapper)
        {
            _boxServices = customerServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<BoxViewModel> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get Box request");
                var result = _boxServices.GetById(id);
                return Ok(_mapper.Map<BoxViewModel>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Spot/{spotid}")]
        public ActionResult<List<BoxViewModel>> GetbySpot(int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Box request");
                var result = _boxServices.GetbySpot(spotid);
                return Ok(_mapper.Map<List<BoxViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("SpotCust/{spotid}")]
        public ActionResult<List<BoxViewModel>> GetbySpotCust([FromHeader] int custid, int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Box request");
                var result = _boxServices.GetbySpotCust(spotid, custid);
                return Ok(_mapper.Map<List<BoxViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("SpotOwner/{spotid}")]
        public ActionResult<List<BoxViewModel>> GetbySpotOwner([FromHeader] int ownerid, int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Box request");
                var result = _boxServices.GetbySpotOwner(spotid, ownerid);
                return Ok(_mapper.Map<List<BoxViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("BoxNumber/{spotid}")]
        public ActionResult<List<BoxViewModel>> GetbySpotBoxNumber([FromHeader] int boxnumber, int spotid)
        {
            try
            {
                _logger.LogInformation("Received get list Box request");
                var result = _boxServices.GetbySpotBoxNumber(spotid, boxnumber);
                return Ok(_mapper.Map<List<BoxViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost("{spotid}")]
        public ActionResult<string> InsertNewBox([FromHeader] int boxnumber, int spotid)
        {
            try
            {
                _logger.LogInformation("Received post Shelf request");
                _boxServices.InsertNewBox(spotid,boxnumber);
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("{wish}")]
        public ActionResult<string> UpdateBox([FromBody] WishViewModel wish)
        {
            try
            {
                _logger.LogInformation("Received patch Box request");
                _boxServices.UpdateBox(_mapper.Map<Wish>(wish));
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Occup/{boxid}")]
        public ActionResult<string> SetBoxOccupied(int boxid)
        {
            try
            {
                _logger.LogInformation("Received patch Box occupied request");
                _boxServices.SetBoxOccupied(boxid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Empty/{boxid}")]
        public ActionResult<string> SetBoxEmpty(int boxid)
        {
            try
            {
                _logger.LogInformation("Received patch Box empty request");
                _boxServices.SetBoxEmpty(boxid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("{boxid}")]
        public ActionResult<string> RemoveBox(int boxid)
        {
            try
            {
                _logger.LogInformation("Received delete Spot to Customer request");
                _boxServices.RemoveBox(boxid);
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