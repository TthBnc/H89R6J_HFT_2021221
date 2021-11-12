using H89R6J_HFT_2021221.Data;
using H89R6J_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Repository
{
    public class CarRepository : IDefaultRepository<Car>
    {
        CarShopContext context;
        public CarRepository(CarShopContext ctx)
        {
            context = ctx;
        }
        public void Create(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public Car ReadOne(int id)
        {
            return context
                .Cars
                .FirstOrDefault(c => c.Id == id);
        }
        public IQueryable<Car> ReadAll()
        {
            return context.Cars;
        }

        public void Update(Car car)
        {
            Car old = ReadOne(car.Id);

            old.Model = car.Model;
            old.BasePrice = car.BasePrice;
            old.BrandId = car.BrandId;
            

            context.SaveChanges();
        }

        public void Delete(int carId)
        {
            context.Cars.Remove(ReadOne(carId));
            context.SaveChanges();
        }
    }
}
