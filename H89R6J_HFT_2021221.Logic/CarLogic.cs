using H89R6J_HFT_2021221.Models;
using H89R6J_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Logic
{
    public class CarLogic : ICarLogic
    {
        IDefaultRepository<Car> cRepo;
        IDefaultRepository<Brand> bRepo;
        public CarLogic(IDefaultRepository<Car> cRepo,
            IDefaultRepository<Brand> bRepo)
        {
            this.cRepo = cRepo;
            this.bRepo = bRepo;
        }
        public double AveragePrice()
        {
            return cRepo
                .ReadAll()
                .Average(c => c.BasePrice) ?? 0;
        }

        public IEnumerable<KeyValuePair<string, double>> AveragePBB()
        {
            return from c in cRepo.ReadAll()
                   join b in bRepo.ReadAll()
                   on c.BrandId equals b.Id
                   group c by b.Name into g
                   select new KeyValuePair<string, double>(
                       g.Key, g.Average(car => car.BasePrice) ?? 0);
        }

        public void Create(Car car)
        {
            cRepo.Create(car);
        }

        public IEnumerable<Car> ReadAll()
        {
            return cRepo.ReadAll();
        }

        public void Update(Car car)
        {
            cRepo.Update(car);
        }

        public void Delete(int carId)
        {
            cRepo.Delete(carId);
        }
    }
}
