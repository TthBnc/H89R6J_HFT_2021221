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

        [HttpGet("{id}")]
        public Engine GetOne(int id)
        {
            return logic.ReadOne(id);
        }

        // POST api/<EngineController>
        [HttpPost]
        public void CreateOne([FromBody] Engine value)
        {
            logic.Create(value);
        }

        // PUT api/<EngineController>/5
        [HttpPut]
        public void UpdateOne([FromBody] Engine value)
        {
            logic.Update(value);
        }

        // DELETE api/<EngineController>/5
        [HttpDelete("{id}")]
        public void DeleteOne(int id)
        {
            logic.Delete(id);
        }
    }
}
