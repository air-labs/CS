﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture04.Models
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}