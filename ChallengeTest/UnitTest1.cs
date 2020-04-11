using System;
using System.Collections.Generic;
using Challenge1;
using Challenge4;
using Challenge6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Challenge6.CAR;

namespace ChallengeTest
{
    [TestClass]
    public class ChallengeTest1
    {

        MenuRepository _menuRepo = new MenuRepository();
        
        Menu item = new Menu();
        Menu item2 = new Menu();
        Menu item3 = new Menu();

        [TestMethod]
        public void AddMenuItemtoList_Test()
        {

            //Arrange

            _menuRepo.AddItem(item);
            _menuRepo.AddItem(item2);
            _menuRepo.AddItem(item3);

            //ACT

            int actual = _menuRepo.GetList().Count;
            int expected = 3;

            //Assert

            Assert.AreEqual(expected, actual);
        }

            [TestMethod]
        public void RemoveMenuItemFromList_Test()
        {
            _menuRepo.RemoveMenuItem(item);

            int actual = _menuRepo.GetList().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

    }

    [TestClass]
    public class ChallengeTest4
    {
        OutingRepository _outingRepo = new OutingRepository();


        [TestMethod]
        public void AddOutingShouldReturnValue()
        {

            List<Outing> testList = _outingRepo.GetList();
            _outingRepo.AddOuting(Outing.EventType.AmusementPark, 10, DateTime.Today, 5m, 100m);

            var actual = _outingRepo.GetList().Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetTotalCostOfOuting()
        {
            List<Outing> testList = _outingRepo.GetList();
            _outingRepo.AddOuting(Outing.EventType.AmusementPark, 10, DateTime.Today, 5m, 100m);
            _outingRepo.AddOuting(Outing.EventType.Bowling, 15, DateTime.Today, 5m, 200m);

            var actual = _outingRepo.GetList().Count;
            var expected = 300m;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGetTotalCostByEventType()
        {
            List<Outing> testList = _outingRepo.GetList();
            _outingRepo.AddOuting(Outing.EventType.AmusementPark, 10, DateTime.Today, 5m, 100m);
            _outingRepo.AddOuting(Outing.EventType.Bowling, 15, DateTime.Today, 5m, 200m);

            var actual = _outingRepo.GetCostByType(Outing.EventType.Bowling);
            var expected = 200m;

            Assert.AreEqual(expected, actual);


        }
    }
    [TestClass]
    public class ChallengeTest6
    {
        CarRepository _carRepo = new CarRepository();

        CAR car1 = new CAR(2002, "Honda", "Accord", CAR.CarType.Hybrid);
        CAR car2 = new CAR(2010, "Toyota", "Tundra", CAR.CarType.Gas);
        CAR car3 = new CAR(2020, "Ford", "Fusion", CAR.CarType.Electric);

        [TestMethod]
        public void ShouldAddCarToList()
        {

            List<CAR> carList = _carRepo.GetCarList();


            _carRepo.AddCarToList(car1);
            _carRepo.AddCarToList(car2);
            _carRepo.AddCarToList(car3);


            var actual = carList.Count;
            var expected = 3;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void ShouldGetCarByType()
        {
            List<CAR> carList = _carRepo.GetCarList();

            _carRepo.AddCarToList(car1);
            _carRepo.AddCarToList(car2);
            _carRepo.AddCarToList(car3);

            var actual = _carRepo.UpdateCarType(CarType.Gas);
            var expected = 1;

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ShouldRemoveCarFromList()
        {
            List<CAR> carList = _carRepo.GetCarList();

            _carRepo.AddCarToList(car1);
            _carRepo.AddCarToList(car2);
            _carRepo.AddCarToList(car3);

            _carRepo.RemoveCarFromList(car1);

            var actual = _carRepo.GetCarList().Count;
            var expected = 2;

            Assert.AreEqual(expected, actual);

        }
    }


}
