using apartmant.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly DataContext _context;
        static int id = 0;
        // GET: api/<RecreationController>
        public SaleController(DataContext DC)
        {
            _context = DC;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public IEnumerable<Sale> Get()
        {
            return _context.sales;
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public Sale Get(int id)
        {
            return _context.sales.Find(e=>e.Id==id);
        }

        // POST api/<SaleController>
        [HttpPost]
        public void Post([FromBody] Sale value)
        {
            value.Id = id++;
            _context.sales.Add(value);
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sale value)
        {
            var val= _context.sales.Find(e=>e.Id==id);
            val.Id=value.Id;
            val.Name=value.Name;    
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var val= _context.sales.Find(e=>e.Id==id);
            _context.sales.Remove(val);
        }
    }
}
