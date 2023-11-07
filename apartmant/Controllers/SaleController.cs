using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apartmant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        static List<Sale> sales=new List<Sale>;
        static int id=0;
        // GET: api/<SaleController>
        [HttpGet]
        public IEnumerable<Sale> Get()
        {
            return sales;
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public Sale Get(int id)
        {
            return sales.Find(e=>e.Id==id);
        }

        // POST api/<SaleController>
        [HttpPost]
        public void Post([FromBody] Sale value)
        {
            value.Id = id++;
            sales.Add(value);
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sale value)
        {
            let val=sales.Find(e=>e.Id==id);
            val.Id=value.Id;
            val.Name=value.Name;    
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             let val=sales.Find(e=>e.Id=id);
            sales.Remove(val);
        }
    }
}
