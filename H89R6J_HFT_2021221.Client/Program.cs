using H89R6J_HFT_2021221.Data;
using System;
using System.Linq;

namespace H89R6J_HFT_2021221.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShopContext ctx = new CarShopContext();

            var res1 = ctx.Cars.ToList();
            ;
        }
    }
}
