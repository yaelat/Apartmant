using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Solid.Core.service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecreationController : ControllerBase
    {
        private readonly IRecreationService _recreationService;
        static int id = 0;
        // GET: api/<RecreationController>
        public RecreationController(IRecreationService recreationService)
        {
            _recreationService = recreationService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_recreationService.GetAllRecreation);
        }

        // GET api/<RecreationController>/5
        [HttpGet("{id}")]
        public Recreation Get(int id)
        {
            return _context.recreations.Find(e => e.Id == id);
        }

        // POST api/<RecreationController>
        [HttpPost]
        public void Post([FromBody] Recreation value)
        {
            value.Id = id++;
            _context.recreations.Add(value);
        }

        // PUT api/<RecreationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recreation value)
        {
            var val = _context.recreations.Find(e => e.Id == id);
            val.Id = value.Id;
            val.Price = value.Price;
            val.NameOner = value.NameOner;
            val.Number = value.Number;
            val.Adress = value.Adress;

        }

        // DELETE api/<RecreationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var val = _context.recreations.Find(e => e.Id == id);
            _context.recreations.Remove(val);
        }
    }
}
