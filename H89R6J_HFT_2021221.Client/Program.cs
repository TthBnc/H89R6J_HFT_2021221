using H89R6J_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H89R6J_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(8000);

            RestService rest = new RestService("http://localhost:44728");

            var brands = rest.Get<Brand>("brand");

            var avgprice = rest.GetSingle<KeyValuePair<string, double>>("stat/averagepbb");
            ;
        }
    }
}
