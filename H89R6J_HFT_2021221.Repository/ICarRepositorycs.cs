﻿using H89R6J_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Repository
{
    interface ICarRepository
    {
        void Create(Car car);
        Car ReadOne(int id);
        IQueryable<Car> ReadAll();
        void Update(Car car);
        void Delete(int carId);
    }
}
