using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleAndRentingController : ControllerBase
    {
        private readonly ISaleAndRentingService _saleAndRentingService;
        static int id = 0;
        // GET: api/<RecreationController>
        public SaleAndRentingController(ISaleAndRentingService saleAndRentingService)
        {
            _saleAndRentingService = saleAndRentingService;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_saleAndRentingService.GetAllSaleAndRenting());
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public SaleAndRenting Get(int id)
        {
            return _saleAndRentingService.GetSaleAndRentingById(id);
        }

        // POST api/<SaleController>
        [HttpPost]
        public SaleAndRenting Post([FromBody] SaleAndRenting value)
        {
           return _saleAndRentingService.PostSaleAndRenting(value);    
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SaleAndRenting value)
        {
            _saleAndRentingService.PutSaleAndRanting(id, value);
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _saleAndRentingService.DeleteSaleAndRenting(id);
        }
    }
}
