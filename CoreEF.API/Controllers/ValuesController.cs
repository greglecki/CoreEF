using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEF.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoreEF.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IExampleRepo _repo;
        public ValuesController(IExampleRepo repo)
        {
            this._repo = repo;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.getExamples());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
