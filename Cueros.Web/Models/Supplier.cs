﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public Picture Picture{ get; set; }
    }
}