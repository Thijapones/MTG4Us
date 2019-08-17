using System;
using System.Collections.Generic;
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
        public ActionResult<List<Customer>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received post request");
                var clients = _customerServices.GetAll();
                return Ok(_mapper.Map<List<Customer>>(clients));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetById(int id)
        {
            try
            {
                _logger.LogInformation("Received get list price request");
                var result = _customerServices.GetById(id);
                return Ok(_mapper.Map<Customer>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("Name/{name}")]
        public ActionResult<List<Customer>> GetByName(string name)
        {
            try
            {
                _logger.LogInformation("Received get list price request");
                var result = _customerServices.GetByName(name);
                return Ok(_mapper.Map<List<Customer>>(result));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Customer customer)
        {
            try
            {
                _logger.LogInformation("Received post price request");
                _customerServices.Insert(_mapper.Map<Customer>(customer));
                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Customer> Update(Customer customer)
        {
            try
            {
                _logger.LogInformation("Received put price request");
                _customerServices.Update(_mapper.Map<Customer>(customer));
                return Ok(_mapper.Map<Customer>(customer));
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
                _logger.LogInformation("Received put price request");
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
                _logger.LogInformation("Received put price request");
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