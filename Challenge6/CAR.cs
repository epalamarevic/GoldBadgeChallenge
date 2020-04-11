using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public class CAR
    {
        public enum CarType
        {
            Electric,
            Hybrid,
            Gas
        }

        public CarType CType { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }



        public CAR() { }
        public CAR(int year, string make, string model, CarType cType)
        {
            CType = cType;
            Year = year;
            Make = make;
            Model = model;

        }
    }
}
