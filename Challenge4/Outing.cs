using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class Outing
    {
        public enum EventType
        {
            Golf, Bowling, AmusementPark, Concert
        }


        public EventType OutingType { get; set; }
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public decimal IndividualCost { get; set; }
        public decimal TotalEventCost { get; set; }


        public Outing() { }

        public Outing(EventType outingType, int attendees, DateTime date, decimal individualCost, decimal totalEventCost)
        {
            OutingType = outingType;
            Attendees = attendees;
            Date = date;
            IndividualCost = individualCost;
            TotalEventCost = totalEventCost;
        }
    }
}
