﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExecutiveBonusUI.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}