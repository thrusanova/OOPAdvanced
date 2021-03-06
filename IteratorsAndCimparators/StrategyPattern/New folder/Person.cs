﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class Person
    {
        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; set; }

    
        public override string ToString()
        {
            return this.Name + " " + this.Age;
        }

    }
}
