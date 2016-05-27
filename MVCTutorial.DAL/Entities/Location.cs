﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTutorial.DAL.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string DisplayName { get; set; }
    }
}
