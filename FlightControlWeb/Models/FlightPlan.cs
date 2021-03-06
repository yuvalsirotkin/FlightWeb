﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public class FlightPlan
    {
        public int passengers { get; set; }
        public string company_name { get; set; }
        public Location initial_location { get; set; }
        public List<Segment> segments { get; set; }
        public int id { get; set; }
    }
}
