﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W3IntroToPolymorphism
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double Earnings();

        public override string ToString()
        {
            return $"Id = {Id}\nName = {Name}\n";
        }
    }
}
