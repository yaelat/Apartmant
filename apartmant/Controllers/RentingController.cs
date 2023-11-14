using apartmant.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentingController : ControllerBase
    {
        private readonly DataContext _context;
        static int id = 0;
        // GET: api/<RecreationController>
        public RentingController(DataContext DC)
        {
            _context = DC;
        }
        
        // GET: api/<RentingController>
        [HttpGet]
        public IEnumerable<Renting> Get()
        {
            return _context.rentings;
        }

        // GET api/<RentingController>/5
        [HttpGet("{id}")]
        public Renting Get(int id)
        {
            return _context.rentings.Find(e=>e.Id==id);
        }

        // POST api/<RentingController>
        [HttpPost]
        public void Post([FromBody] Renting value)
        {
            value.Id=id++;
            _context.rentings.Add(value);
        }

        // PUT api/<RentingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Renting value)
        {
            var val= _context.rentings.Find(e=>e.Id==id);
            val.Id=value.Id;
            val.Name=value.Name;    
        }

        // DELETE api/<RentingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var val= _context.rentings.Find(e=>e.Id==id);
            _context.rentings.Remove(val);
        }
    }
}
