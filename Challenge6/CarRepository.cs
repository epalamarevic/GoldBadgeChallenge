using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Challenge6.CAR;

namespace Challenge6
{
    public class CarRepository
    {
        private List<CAR> _carList = new List<CAR>();


        //CREATE//
        public void AddCarToList(CAR car)
        {
            _carList.Add(car);
        }

        //READ//
        public List<CAR> GetCarList()
        {
            return _carList;
        }

        //UPDATE//
        public List<CAR> UpdateCarType(CarType ctype)
        {
            List<CAR> returnList = new List<CAR>();

            foreach (CAR car in _carList)
            {
                if (car.CType == ctype) returnList.Add(car);
            }
            return returnList;
        }

        //DELETE//
        public void RemoveCarFromList(CAR car)
        {
            _carList.Remove(car);
        }
    }
}
