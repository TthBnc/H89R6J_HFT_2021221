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
        double HighestPrice();
        double AveragePrice();
        IEnumerable<KeyValuePair<string, double>> AveragePBB();
        IEnumerable<KeyValuePair<string, double>> AveragePriceByEngineTypes();
        IEnumerable<KeyValuePair<string, double>> EngineTypeUsage();
        void Create(Car car);
        IEnumerable<Car> ReadAll();
        void Update(Car car);
        void Delete(int carId);
    }
}
