using H89R6J_HFT_2021221.Models;
using H89R6J_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Logic
{
    public class BrandLogic : IBrandLogic
    {
        //IDefaultRepository<Car> cRepo;
        IDefaultRepository<Brand> bRepo;
        public BrandLogic(IDefaultRepository<Brand> bRepo)
        {
            this.bRepo = bRepo;
        }

        public void Create(Brand brand)
        {
            bRepo.Create(brand);
        }

        public IEnumerable<Brand> ReadAll()
        {
            return bRepo.ReadAll();
        }

        public void Update(Brand brand)
        {
            bRepo.Update(brand);
        }

        public void Delete(int brandId)
        {
            bRepo.Delete(brandId);
        }
    }
}
