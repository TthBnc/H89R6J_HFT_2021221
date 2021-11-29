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
        //[HttpGet("{id}")]
        //public Car Get(int id)
        //{
        //    return logic;
        //}

        // POST /car
        //Create
        [HttpPost]
        public void AddOne([FromBody] Car value)
        {
            logic.Create(value);
        }

        // PUT /car
        //Update
        [HttpPut]
        public void EditOne([FromBody] Car value)
        {
            logic.Update(value);
        }

        // DELETE /car/{carId}
        [HttpDelete("{id}")]
        public void DeleteOne([FromRoute] int carId)
        {
            logic.Delete(carId);
        }
    }
}
