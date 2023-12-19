using Microsoft.AspNetCore.Mvc;
using Solid.Core.service;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;
        // GET: api/<RecreationController>
        public CustomersController(ICustomersService customerService)
        {
            _customersService = customerService;
        }

        // GET: api/<RentingController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customersService.GetAllCustomers());
        }

        // GET api/<RentingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_customersService.GetCustomerById(id));
        }

        // POST api/<RentingController>
        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            return _customersService.PostCustomer(value);
        }

        // PUT api/<RentingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            _customersService.PutCustomer(id, value);
        }

        // DELETE api/<RentingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customersService.DeleteCustomer(id);
        }
    }
}