using H89R6J_HFT_2021221.Models;
using System.Collections.Generic;

namespace H89R6J_HFT_2021221.Logic
{
    public interface IBrandLogic
    {
        void Create(Brand brand);
        void Delete(int brandId);
        IEnumerable<Brand> ReadAll();
        void Update(Brand brand);
    }
}