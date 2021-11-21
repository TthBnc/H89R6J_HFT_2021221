using H89R6J_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Logic
{
    public interface ICarLogic
    {
        public double AveragePrice();
        IEnumerable<KeyValuePair<string, double>> AveragePBB();
        void Create(Car car);
        IEnumerable<Car> ReadAll();
        void Update(Car car);
        void Delete(int carId);
    }
}
