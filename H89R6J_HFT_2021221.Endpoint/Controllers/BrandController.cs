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
    public class BrandController : ControllerBase
    {

        IBrandLogic logic;
        public BrandController(IBrandLogic lc)
        {
            this.logic = lc;
        }
        // GET: api/<BrandController>
        [HttpGet]
        public IEnumerable<Brand> GetAll()
        {
            return logic.ReadAll();
        }

        [HttpGet("{id}")]
        public Brand GetOne(int id)
        {
            return logic.ReadOne(id);
        }

        // POST api/<BrandController>
        [HttpPost]
        public void AddOne([FromBody] Brand value)
        {
            logic.Create(value);
        }

        // PUT api/<BrandController>/5
        [HttpPut]
        public void UpdateOne([FromBody] Brand value)
        {
            logic.Update(value);
        }

        // DELETE api/<BrandController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logic.Delete(id);
        }
    }
}
