using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class FlightPlan
    {
        public int Passengers { get; set; }
        public string Company_name { get; set; }
        public Location Initial_location { get; set; }
        public List<Segment> Segments { get; set; }
        public int Id { get; set; }
    }
}
