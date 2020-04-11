using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Challenge4.Outing;

namespace Challenge4
{
    public class OutingRepository
    {
        List<Outing> _outingList = new List<Outing>();

        public List<Outing> GetList()
        {
            return _outingList;
        }

        public void AddOuting(EventType outingType, int attendees, DateTime date, decimal individualCost, decimal totalEventCost)
        {
            Outing newOuting = new Outing(outingType, attendees, date, individualCost, totalEventCost);
            _outingList.Add(newOuting);
        }

        public decimal TotalCost()
        {
            decimal totalCost = 0m;

            foreach (Outing outing in _outingList)
            {
                totalCost = totalCost + outing.TotalEventCost;
            }

            return totalCost;
        }

        public decimal GetCostByType(EventType type)
        {
            decimal totalCost = 0m;

            foreach (Outing outing in _outingList)
            {
                if (outing.OutingType == type)
                {
                    totalCost = totalCost + outing.TotalEventCost;
                }
            }

            return totalCost;
        }
    }
}
