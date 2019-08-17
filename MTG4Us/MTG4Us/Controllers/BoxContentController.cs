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
    public class BoxContentController : ControllerBase
    {
        private readonly IBoxContentServices _boxcontentServices;
        private readonly ILogger<BoxContentController> _logger;
        private readonly IMapper _mapper;
        public BoxContentController(IBoxContentServices customerServices, ILogger<BoxContentController> logger, IMapper mapper)
        {
            _boxcontentServices = customerServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("{boxid}")]
        public ActionResult<string> InsertNewContent([FromBody] WishViewModel wish, [FromRoute] int boxid)
        {
            try
            {
                _logger.LogInformation("Received post Box Content request");
                _boxcontentServices.InsertNewContent(_mapper.Map<Wish>(wish),boxid);
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("{boxid}")]
        public ActionResult<string> EmptyBox(int boxid)
        {
            try
            {
                _logger.LogInformation("Received delete Box Content to Customer request");
                _boxcontentServices.EmptyBox(boxid);
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