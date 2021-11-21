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
        IDefaultRepository<Car> repo;
        public CarLogic(IDefaultRepository<Car> repository)
        {
            this.repo = repository;
        }

        public void Create(Car car)
        {
            repo.Create(car);
        }
        public IQueryable<Car> ReadAll()
        {
            return repo.ReadAll();
        }

        public void Update(Car car)
        {
            repo.Update(car);
        }

        public void Delete(int carId)
        {
            repo.Delete(carId);
        }
    }
}
