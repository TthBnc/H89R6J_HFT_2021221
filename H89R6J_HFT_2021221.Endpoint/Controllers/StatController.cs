using H89R6J_HFT_2021221.Logic;
using H89R6J_HFT_2021221.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        ICarLogic cl;
        IBrandLogic bl;
        IEngineLogic el;

        public StatController(ICarLogic cl, IBrandLogic bl, IEngineLogic el)
        {
            this.cl = cl;
            this.bl = bl;
            this.el = el;
        }

        // GET: /stat/averagePBB
        [HttpGet]
        public IEnumerable<KeyValuePair<string, double>> AveragePBB()
        {
            return cl.AveragePBB();
        }

        // GET: /stat/AveragePriceByEngineTypes
        [HttpGet]
        public IEnumerable<KeyValuePair<string, double>> AveragePriceByEngineTypes()
        {
            return cl.AveragePBB();
        }

        // GET: /stat/EngineTypeUsage
        [HttpGet]
        public IEnumerable<KeyValuePair<string, double>> EngineTypeUsage()
        {
            return cl.EngineTypeUsage();
        }

        [HttpGet]
        public IEnumerable<KeyValuePair<string, double>> BrandPopularity()
        {
            return bl.BrandPopularity();
        }

        [HttpGet]
        public IEnumerable<KeyValuePair<string, int?>> DieselCostHigherThan4k()
        {
            return el.DieselCostHigherThan4k();
        }
    }
}
