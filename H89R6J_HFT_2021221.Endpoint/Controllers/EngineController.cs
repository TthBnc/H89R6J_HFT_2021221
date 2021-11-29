using H89R6J_HFT_2021221.Logic;
using H89R6J_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace H89R6J_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EngineController : ControllerBase
    {
        IEngineLogic logic;

        public EngineController(IEngineLogic lc)
        {
            this.logic = lc;
        }

        // GET: api/<EngineController>
        [HttpGet]
        public IEnumerable<Engine> GetAll()
        {
            return logic.ReadAll();
        }

        // GET api/<EngineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EngineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EngineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EngineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
