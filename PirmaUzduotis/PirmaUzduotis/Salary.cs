﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaUzduotis
{
    public abstract class Salary
    {
        public Person person;

        public abstract double getSalary();
    }
}