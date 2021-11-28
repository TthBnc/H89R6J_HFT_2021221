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
    public class CarController : ControllerBase
    {

        ICarLogic logic;

        public CarController(ICarLogic cl)
        {
            this.logic = cl;
        }

        // GET: /car
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return logic.ReadAll();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE /car/{carId}
        [HttpDelete("{carId}")]
        public void Delete([FromRoute]int carId)
        {
            logic.Delete(carId);
        }
    }
}
