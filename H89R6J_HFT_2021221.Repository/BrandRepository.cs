using H89R6J_HFT_2021221.Data;
using H89R6J_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Repository
{
    public class BrandRepository : IDefaultRepository<Brand>
    {
        CarShopContext context;

        public BrandRepository(CarShopContext ctx)
        {
            context = ctx;
        }

        public void Create(Brand brand)
        {
            context.Add(brand);
            context.SaveChanges();
        }

        public Brand ReadOne(int id)
        {
            return context
                .Brands
                .FirstOrDefault(e => e.Id == id);
        }
        public IQueryable<Brand> ReadAll()
        {
            return context.Brands;
        }
        public void Update(Brand brand)
        {
            Brand old = ReadOne(brand.Id);

            old.Name = brand.Name;
        }

        public void Delete(int brandID)
        {
            context.Brands.Remove(ReadOne(brandID));
            context.SaveChanges();
        }
    }
}
