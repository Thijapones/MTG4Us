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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class CustomerController : ControllerBase
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private readonly ICustomerServices _customerServices;
        private readonly ILogger<CustomerController> _logger;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerServices customerServices, ILogger<CustomerController> logger, IMapper mapper)
        {
            _customerServices = customerServices;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<CustomerViewModel>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received GetAll request");
                var clients = _customerServices.GetAll();
                return Ok(_mapper.Map<List<CustomerViewModel>>(clients));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerViewModel> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get list Customer request");
                var result = _customerServices.GetById(id);
                return Ok(_mapper.Map<CustomerViewModel>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Name/{name}")]
        public ActionResult<List<CustomerViewModel>> GetByName(string name)
        {
            try
            {
                _logger.LogInformation("Received get list Customer request");
                var result = _customerServices.GetByName(name);
                return Ok(_mapper.Map<List<CustomerViewModel>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<Customer> Post([FromBody] CustomerViewModel customer)
        {
            try
            {
                _logger.LogInformation("Received post Customer request");
                _customerServices.Insert(_mapper.Map<Customer>(customer));
                return Ok(_mapper.Map<CustomerViewModel>(customer));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Customer> Update(CustomerViewModel customer)
        {
            try
            {
                _logger.LogInformation("Received put Customer request");
                _customerServices.Update(_mapper.Map<Customer>(customer));
                return Ok(_mapper.Map<CustomerViewModel>(customer));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Activate/{id}")]
        public ActionResult<string> ActivateCustomer(int id)
        {
            try
            {
                _logger.LogInformation("Received patch Customer request");
                _customerServices.ActivateCustomer(id);                    
                return Ok("OK");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPatch("Inactivate/{id}")]
        public ActionResult<string> InactivateCustomer(int id)
        {
            try
            {
                _logger.LogInformation("Received patch Customer request");
                _customerServices.InactivateCustomer(id);
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