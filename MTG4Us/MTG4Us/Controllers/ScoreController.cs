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
    public class ScoreController : ControllerBase
    {
        private readonly IScoreServices _scoreServices;
        private readonly ILogger<ScoreController> _logger;
        private readonly IMapper _mapper;

        public ScoreController(IScoreServices spotServices, ILogger<ScoreController> logger, IMapper mapper)
        {
            _scoreServices = spotServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{custid}")]
        public ActionResult<List<ScoreViewModel>> GetByCustId(int custid)
        {
            try
            {
                _logger.LogInformation("Received get list Score request");
                var result = _scoreServices.GetByCustId(custid);
                return Ok(_mapper.Map<List<ScoreViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> InsertScore([FromBody] ScoreViewModel customer)
        {
            try
            {
                _logger.LogInformation("Received post Score request");
                _scoreServices.Insert(_mapper.Map<Score>(customer));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("DecreaseBorrowRep/{custid}")]
        public ActionResult<string> DecreaseBorrowRep(int custid)
        {
            try
            {
                _logger.LogInformation("Received patch Score DecreaseBorrowRep request");
                _scoreServices.DecreaseBorrowRep(custid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("DecreaseOwnerRep/{custid}")]
        public ActionResult<string> DecreaseOwnerRep(int custid)
        {
            try
            {
                _logger.LogInformation("Received patch Score DecreaseOwnerRep request");
                _scoreServices.DecreaseOwnerRep(custid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("IncreaseBorrowRep/{custid}")]
        public ActionResult<string> IncreaseBorrowRep(int custid)
        {
            try
            {
                _logger.LogInformation("Received patch Score IncreaseBorrowRep request");
                _scoreServices.IncreaseBorrowRep(custid);
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("IncreaseOwnerRep/{custid}")]
        public ActionResult<string> IncreaseOwnerRep(int custid)
        {
            try
            {
                _logger.LogInformation("Received patch Score IncreaseOwnerRep request");
                _scoreServices.IncreaseOwnerRep(custid);
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