using H89R6J_HFT_2021221.Logic;
using H89R6J_HFT_2021221.Models;
using H89R6J_HFT_2021221.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H89R6J_HFT_2021221.Test
{
    class Tester
    {
        ICarLogic carLogic;
        public Tester()
        {
            var mockCarRepo = new Mock<IDefaultRepository<Car>>();

            Brand b1 = new Brand() { Name = "BMW" };
            Brand b2 = new Brand() { Name = "Audi" };

            mockCarRepo
                .Setup(x => x.ReadAll())
                .Returns(new List<Car>
                {
                    new Car() {
                        BasePrice = 5000,
                        Brand = b1
                    },
                    new Car() {
                        BasePrice = 6000,
                        Brand = b1
                    },
                    new Car() {
                        BasePrice = 4500,
                        Brand = b2
                    },
                    new Car() {
                        BasePrice = 7700,
                        Brand = b2
                    },
                    new Car() {
                        BasePrice = 7500,
                        Brand = b2
                    },
                    new Car() {
                        BasePrice = 3200,
                        Brand = b2
                    },
                }.AsQueryable());

            //carLogic = new CarLogic(mockCarRepo.Object);

            //c1 = new CarLogic(mockCarRepo.Object); //carlogic konstruktorban van brand
        }
        [Test]
        public void Test1()
        {

        }
        [Test]
        public void Test2()
        {

        }
        [Test]
        public void Test3()
        {

        }
        [Test]
        public void Test4()
        {

        }
        [Test]
        public void Test5()
        {

        }
    }
}
