﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMonit_DLog.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
    }
}