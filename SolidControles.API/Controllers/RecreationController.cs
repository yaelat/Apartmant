using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Solid.Core.Entities;
using Solid.Core.service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecreationController : ControllerBase
    {
        private readonly IRecreationService _recreationService;
        // GET: api/<RecreationController>
        public RecreationController(IRecreationService recreationService)
        {
            _recreationService = recreationService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_recreationService.GetAllRecreation());
        }

        // GET api/<RecreationController>/5
        [HttpGet("{id}")]
        public Recreation Get(int id)
        {
            return _recreationService.GetRecreationById(id);
        }

        // POST api/<RecreationController>
        [HttpPost]
        public Recreation Post([FromBody] Recreation value)
        {
            return _recreationService.PostRecreation(value);
        }

        // PUT api/<RecreationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recreation value)
        {
            _recreationService.PutRecreation(id, value);

        }

        // DELETE api/<RecreationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _recreationService.DeleteRecreation(id);
        }
    }
}
